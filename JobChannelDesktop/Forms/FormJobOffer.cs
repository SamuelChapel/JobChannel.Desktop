using System.ComponentModel;
using System.Text.RegularExpressions;
using BLL.Services.Contracts;
using BLL.Services.Geographic;
using BLL.Services.Geographic.Requests;
using BLL.Services.JobOffers;
using BLL.Services.JobOffers.Requests;
using BLL.Services.JobOffers.Resquests;
using BLL.Services.Jobs;
using JobChannel.Domain.BO;

namespace JobChannelDesktop.Forms;

public partial class FormJobOffer : Form
{
    private List<Job> allJobs;
    private readonly BindingList<Job> jobs;
    private readonly BindingList<Contract> contracts;
    private readonly BindingList<CityGetResponse> cities;

    private readonly IJobService _jobService;
    private readonly IJobOfferService _jobOfferService;
    private readonly IContractService _contractService;
    private readonly IGeoService _geoService;

    public JobOfferFindResponse? JobOffer { get; set; }

    public FormJobOffer(IJobService jobService, IContractService contractService, IGeoService geoService, IJobOfferService jobOfferService, JobOffer? jobOffer = null)
    {
        allJobs = new();
        jobs = new();
        contracts = new();
        cities = new();

        _jobService = jobService;
        _contractService = contractService;
        _geoService = geoService;
        _jobOfferService = jobOfferService;

        InitializeComponent();
        InitializeBinding();
        InitialData();
    }

    private void InitializeBinding()
    {
        jobBindingSource.DataSource = jobs;

        contractBindingSource.DataSource = contracts;

        cityGetResponseBindingSource.DataSource = cities;
    }

    private void InitialData()
    {
        dtpPublication.Value = DateTime.Today;
        dtpPublication.MaxDate = DateTime.Today;
        dtpPublication.MinDate = DateTime.Today.AddMonths(-1);

        GetJobs();

        GetContracts();
    }

    private async void GetJobs()
    {
        try
        {
            allJobs = (await _jobService.GetJobs())!.ToList();

            Invoke(() =>
            {
                jobs.Clear();
                allJobs?.Take(100).ToList().ForEach(job => jobs.Add(job));
            });
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les postes", "Erreur API");
        }
    }

    private JobOffer? GetJobOfferById(int id)
    {
        try
        {
            return Task.Run(() => _jobOfferService.GetJobOfferById(id)).Result;
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer le poste", "Erreur API");
            return null;
        }
    }

    private async void GetContracts()
    {
        try
        {
            var getContracts = await _contractService.GetContracts();

            Invoke(() =>
            {
                contracts.Clear();
                getContracts?.ToList().ForEach(contract => contracts.Add(contract));
            });


        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les postes", "Erreur API");
        }
    }

    private async void GetCitiesByName(string name)
    {
        try
        {
            var getCities = await _geoService.GetCitiesByName(name);

            Invoke(() =>
            {
                cities.Clear();
                getCities?.ToList().ForEach(city => cities.Add(city));
            });
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les villes", "Erreur API");
        }
    }

    private void FilterJobs(string name)
    {
        try
        {
            var filteredJobs = allJobs.Where(j => j.Name.Contains(cbJob.Text)).Take(100).ToList();

            if (filteredJobs.Any())
                Invoke(() =>
                {
                    jobs.Clear();
                    filteredJobs.ForEach(job => jobs.Add(job));
                    //cbJob.
                });
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les postes", "Erreur API");
        }
    }

    private void InsertJobOffer(JobOfferCreateRequest jobOffer)
    {
        try
        {
            var createResponse = Task.Run(() => _jobOfferService.CreateJobOffer(jobOffer)).Result;
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de créer une annonce", "Erreur lors de la crétion");
        }
    }

    private void ModifyJobOffer(JobOfferUpdateRequest jobOffer)
    {
        try
        {
            var modifyResponse = Task.Run(() => _jobOfferService.ModifyJobOffer(jobOffer)).Result;
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de modifier l'annonce", "Erreur lors de la modification");
        }
    }

    private void timerCities_Tick(object sender, EventArgs e)
    {
        timerCities.Stop();

        if (cbCity.Text.Length > 3)
        {
            GetCitiesByName(cbCity.Text);
        }
    }

    private void cbCity_TextUpdate(object sender, EventArgs e)
    {
        // Redémarre le timer pour retarder la recherche pour ne pas rechercher a chaque changement
        // mais quand l'utilisateur à finit d'entrer ce qu'il veut rechercher
        timerCities.Stop();
        timerCities.Start();

        CheckValidity();
    }

    private void timerJobs_Tick(object sender, EventArgs e)
    {
        timerJobs.Stop();

        if (cbJob.Text.Length > 3)
        {
            FilterJobs(cbJob.Text);
        }
    }

    private void cbJob_TextUpdate(object sender, EventArgs e)
    {
        timerJobs.Stop();
        timerJobs.Start();

        CheckValidity();
    }

    private void btCancel_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (result == DialogResult.OK)
            Close();
    }

    private void btValidate_Click(object sender, EventArgs e)
    {
        var job = cbJob.SelectedItem as Job;
        var contract = cbContract.SelectedItem as Contract;
        var city = cbCity.SelectedItem as CityGetResponse;

        if (JobOffer == null)
        {
            var jobOfferToCreate = new JobOfferCreateRequest(
            tbTitle.Text,
            tbDescription.Text,
            dtpPublication.Value,
            dtpPublication.Value,
            tbUrl.Text,
            tbSalary.Text,
            tbExperience.Text,
            tbCompany.Text,
            job!.Id,
            contract!.Id,
            city!.Id
            );

            InsertJobOffer(jobOfferToCreate);
        }
        else
        {
            var jobOfferToModify = new JobOfferUpdateRequest(
                JobOffer!.Id,
                tbTitle.Text,
                tbDescription.Text,
                dtpPublication.Value,
                dtpPublication.Value,
                tbUrl.Text,
                tbSalary.Text,
                tbExperience.Text,
                tbCompany.Text,
                job!.Id,
                contract!.Id,
                city!.Id
            );

            ModifyJobOffer(jobOfferToModify);
        }

        Close();
    }

    private void FormJobOffer_Load(object sender, EventArgs e)
    {
        if (JobOffer != null)
        {
            Text = "Modifier l'offre d'emploi";
            btValidate.Text = "Modifier";
            var jobOffer = GetJobOfferById(JobOffer.Id);

            if (jobOffer != null)
            {
                cities.Add(new CityGetResponse(jobOffer.City.Id, jobOffer.City.Name, jobOffer.City.Postcodes.First(), jobOffer.City.Department.Name));
                cbContract.SelectedItem = jobOffer.Contract;
                cbJob.SelectedItem = jobOffer.Job;
                tbCompany.Text = jobOffer.Company;
                tbUrl.Text = jobOffer.Url;
                tbSalary.Text = jobOffer.Salary;
                tbExperience.Text = jobOffer.Experience;
                tbDescription.Text = jobOffer.Description;
                tbTitle.Text = jobOffer.Title;
            }
        }
        else
        {
            btValidate.Text = "Créer";
        }
    }

    private void CheckValidity()
    {
        bool urlValid = Regex.IsMatch(tbUrl.Text, "^https?://((www\\.[\\w][-a-zA-Z0-9@:%._\\+~#=]{0,254}[\\w])|((?!(www\\.))[\\w][-a-zA-Z0-9@:%._\\+~#=]{0,254}[\\w]))\\.[a-zA-Z0-9()]{2,6}$");

        if (tbTitle.TextLength > 3 &&
            tbDescription.TextLength > 10 &&
            tbExperience.TextLength > 3 &&
            tbSalary.TextLength > 4 &&
            tbCompany.TextLength > 3 &&
            urlValid &&
            cbCity.SelectedItem is CityGetResponse)
        {
            btValidate.Enabled = true;
        }
    }

    private void tbTitle_TextChanged(object sender, EventArgs e)
    {
        CheckValidity();
    }

    private void tbDescription_TextChanged(object sender, EventArgs e)
    {
        CheckValidity();
    }

    private void dtpPublication_ValueChanged(object sender, EventArgs e)
    {
        CheckValidity();
    }

    private void tbUrl_TextChanged(object sender, EventArgs e)
    {
        if (Regex.IsMatch(tbUrl.Text, "^https?://((www\\.[\\w][-a-zA-Z0-9@:%._\\+~#=]{0,254}[\\w])|((?!(www\\.))[\\w][-a-zA-Z0-9@:%._\\+~#=]{0,254}[\\w]))\\.[a-zA-Z0-9()]{2,6}$"))
            tbUrl.ForeColor = Color.Black;
        else
            tbUrl.ForeColor = Color.Red;
        ;
        CheckValidity();
    }

    private void tbSalary_TextChanged(object sender, EventArgs e)
    {
        CheckValidity();
    }

    private void tbExperience_TextChanged(object sender, EventArgs e)
    {
        CheckValidity();
    }

    private void tbCompany_TextChanged(object sender, EventArgs e)
    {
        CheckValidity();
    }

    private void cbJob_SelectedIndexChanged(object sender, EventArgs e)
    {
        CheckValidity();
    }

    private void cbContract_SelectedIndexChanged(object sender, EventArgs e)
    {
        CheckValidity();
    }

    private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        CheckValidity();
    }
}
