using System.ComponentModel;
using BLL.Services.Geographic;
using BLL.Services.JobOffers;
using BLL.Services.JobOffers.Resquests;
using Region = JobChannel.Domain.BO.Region;
using Microsoft.Extensions.DependencyInjection;
using JobChannelDesktop.Forms;
using BLL.Services.Geographic.Requests;
using JobChannel.Domain.BO;
using BLL.Services.Jobs;
using BLL.Services.Contracts;

namespace JobChannelDesktop;

public partial class FormJobChannel : Form
{
    private readonly BindingList<Region> regions;
    private readonly BindingList<DepartmentGetResponse> departments;
    private readonly BindingList<CityGetResponse> cities;

    private readonly BindingList<Job> jobs;
    private readonly BindingList<Contract> contracts;

    private readonly BindingList<JobOfferFindResponse> jobOffers;

    private readonly IJobOfferService _jobOfferService;
    private readonly IGeoService _geoService;
    private readonly IJobService _jobService;
    private readonly IContractService _contractService;

    private JobOfferFindRequest jobOfferFindRequest;

    public FormJobChannel(IJobOfferService jobOfferService, IGeoService geoService, IJobService jobService, IContractService contractService)
    {
        regions = new();
        departments = new();
        jobOffers = new();
        cities = new();
        jobs = new();
        contracts = new();
        jobOfferFindRequest = new();

        _jobOfferService = jobOfferService;
        _geoService = geoService;
        _jobService = jobService;
        _contractService = contractService;

        InitializeComponent();
        InitializeBinding();
    }

    private void InitializeBinding()
    {
        regionBindingSource.DataSource = regions;
        departmentsBS.DataSource = departments;
        cityGetResponseBindingSource.DataSource = cities;

        jobBindingSource.DataSource = jobs;

        contractBindingSource.DataSource = contracts;

        jobOfferBS.DataSource = jobOffers;
        dGVJobOffers.DataSource = jobOfferBS;
    }

    private void RefreshData()
    {
        RefreshRegions();
        RefreshJobs();
        RefreshContracts();

        RefreshJobOffers();
    }

    #region Region
    private async void RefreshRegions()
    {
        try
        {
            var newRegions = await _geoService.GetRegions();

            Invoke(() =>
            {
                var currentRegion = regionBindingSource.Current as Region;

                regions.Clear();
                regions.Add(new Region() { Name = "-- Choisissez une région --" });
                newRegions?.ToList().ForEach(region => regions.Add(region));

                if (currentRegion != null)
                {
                    regionBindingSource.Position = regions.IndexOf(regions.FirstOrDefault(jo => jo.Id == currentRegion.Id)!);
                }

                cbRegion.Enabled = true;
            });
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les régions", "Erreur API");
        }
    }

    private void cbRegion_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cbRegion.SelectedItem is Region r && r.Id != -1)
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = new List<int>() { r.Id },
                Id_Department = null,
                Id_City = null,
                Id_Job = jobOfferFindRequest.Id_Job,
                Id_Contract = jobOfferFindRequest.Id_Contract,
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;

            RefreshDepartments();
        }
        else
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = null,
                Id_Department = null,
                Id_City = null,
                Id_Job = jobOfferFindRequest.Id_Job,
                Id_Contract = jobOfferFindRequest.Id_Contract,
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;

            cbDepartment.Enabled = false;
            departments.Clear();
        }

        cities.Clear();
        cbCity.Enabled = false;

        RefreshJobOffers();
    }

    #endregion Region

    #region Department
    private async void RefreshDepartments()
    {
        try
        {
            var region = cbRegion.SelectedItem as Region;

            var newDepartments = await _geoService.GetDepartments(region!.Id);

            Invoke(() =>
            {
                departments.Clear();
                departments.Add(new DepartmentGetResponse(-1, "-- Choisissez un département --"));
                newDepartments?.ToList().ForEach(department => departments.Add(department));

                cbDepartment.Enabled = true;
            });
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les régions", "Erreur API");
        }
    }

    private void cbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cbDepartment.SelectedItem is DepartmentGetResponse d && d.Id != -1)
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = jobOfferFindRequest.Id_Region,
                Id_Department = new List<int> { d.Id },
                Id_City = null,
                Id_Job = jobOfferFindRequest.Id_Job,
                Id_Contract = jobOfferFindRequest.Id_Contract,
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;

            RefreshCities();
        }
        else
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = jobOfferFindRequest.Id_Region,
                Id_Department = null,
                Id_City = null,
                Id_Job = jobOfferFindRequest.Id_Job,
                Id_Contract = jobOfferFindRequest.Id_Contract,
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;

            cbCity.Enabled = false;
            cities.Clear();
        }

        RefreshJobOffers();
    }

    #endregion Department

    #region City
    private async void RefreshCities()
    {
        try
        {
            var department = cbDepartment.SelectedItem as DepartmentGetResponse;

            var newCities = await _geoService.GetCitiesByDepartment(department!.Id);

            Invoke(() =>
            {
                cities.Clear();
                cities.Add(new CityGetResponse(-1, "-- Choisissez une ville --", "", ""));
                newCities?.ToList().ForEach(city => cities.Add(city));

                cbCity.Enabled = true;
            });
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les villes", "Erreur API");
        }
    }

    private void cbCity_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cbCity.SelectedItem is CityGetResponse c && c.Id != -1)
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = jobOfferFindRequest.Id_Region,
                Id_Department = jobOfferFindRequest.Id_Department,
                Id_City = new List<int> { c.Id },
                Id_Job = jobOfferFindRequest.Id_Job,
                Id_Contract = jobOfferFindRequest.Id_Contract,
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;
        }
        else
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = jobOfferFindRequest.Id_Region,
                Id_Department = jobOfferFindRequest.Id_Department,
                Id_City = null,
                Id_Job = jobOfferFindRequest.Id_Job,
                Id_Contract = jobOfferFindRequest.Id_Contract,
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;
        }

        RefreshJobOffers();
    }

    #endregion City

    #region Job

    private async void RefreshJobs()
    {
        try
        {
            var newJobs = await _jobService.GetJobs();

            Invoke(() =>
            {
                var currentJob = jobBindingSource.Current as Job;

                jobs.Clear();
                jobs.Add(new Job() { Name = "-- Choisissez un poste --" });
                newJobs?.ToList().ForEach(job => jobs.Add(job));

                if (currentJob != null)
                {
                    jobBindingSource.Position = jobs.IndexOf(jobs.FirstOrDefault(jo => jo.Id == currentJob.Id)!);
                }

                cBJob.Enabled = true;
            });
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les postes", "Erreur API");
        }
    }

    private void cBJob_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cBJob.SelectedItem is Job j && j.Id != -1)
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = jobOfferFindRequest.Id_Region,
                Id_Department = jobOfferFindRequest.Id_Department,
                Id_City = jobOfferFindRequest.Id_City,
                Id_Job = new List<int>() { j.Id },
                Id_Contract = jobOfferFindRequest.Id_Contract,
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;
        }
        else
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = jobOfferFindRequest.Id_Region,
                Id_Department = jobOfferFindRequest.Id_Department,
                Id_City = jobOfferFindRequest.Id_City,
                Id_Job = null,
                Id_Contract = jobOfferFindRequest.Id_Contract,
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;
        }

        RefreshJobOffers();
    }

    #endregion Job

    #region Contract

    private async void RefreshContracts()
    {
        try
        {
            var newContracts = await _contractService.GetContracts();

            Invoke(() =>
            {
                var currentContract = contractBindingSource.Current as Contract;

                contracts.Clear();
                contracts.Add(new Contract() { Name = "-- Choisissez un contrat --" });
                newContracts?.ToList().ForEach(contract => contracts.Add(contract));

                if (currentContract != null)
                {
                    contractBindingSource.Position = contracts.IndexOf(contracts.FirstOrDefault(c => c.Id == currentContract.Id)!);
                }

                cBContract.Enabled = true;
            });
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les contrats", "Erreur API");
        }
    }

    private void cBContract_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cBContract.SelectedItem is Contract c && c.Id != -1)
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = jobOfferFindRequest.Id_Region,
                Id_Department = jobOfferFindRequest.Id_Department,
                Id_City = jobOfferFindRequest.Id_City,
                Id_Job = jobOfferFindRequest.Id_Job,
                Id_Contract = new List<int> { c.Id },
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;
        }
        else
        {
            var request = new JobOfferFindRequest()
            {
                Id_Region = jobOfferFindRequest.Id_Region,
                Id_Department = jobOfferFindRequest.Id_Department,
                Id_City = jobOfferFindRequest.Id_City,
                Id_Job = jobOfferFindRequest.Id_Job,
                Id_Contract = null,
                SearchString = tBSearch.Text
            };
            jobOfferFindRequest = request;
        }

        RefreshJobOffers();
    }

    #endregion Contract

    #region JobOffers

    private async void RefreshJobOffers()
    {
        var newJobOffers = await GetJobOffers(jobOfferFindRequest);

        Invoke(() =>
        {
            var currentJobOffer = jobOfferBS.Current as JobOfferFindResponse;

            jobOffers.Clear();
            newJobOffers?.ToList().ForEach(jobOffer => jobOffers.Add(jobOffer));

            if (currentJobOffer != null)
            {
                jobOfferBS.Position = jobOffers.IndexOf(jobOffers.FirstOrDefault(jo => jo.Id == currentJobOffer.Id)!);
            }
        });
    }

    private async Task<IEnumerable<JobOfferFindResponse>?> GetJobOffers(JobOfferFindRequest request)
    {
        try
        {
            var newJobOffers = await _jobOfferService.GetJobOffers(request);

            return newJobOffers;
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de récupérer les offres d'emploi", "Erreur API");
            return null;
        }
    }

    private void DeleteJobOffer(int id)
    {
        var response = Task.Run(() => _jobOfferService.DeleteJobOffer(id)).Result;

        if (response)
        {
            MessageBox.Show("Annonce supprimée", "Supppression");
        }
        else
        {
            MessageBox.Show("Impossible de supprimer l'offre d'emploi", "Erreur API");
        }
    }
    #endregion JobOffers

    private void TBSearch_TextChanged(object sender, EventArgs e)
    {
        // Redémarre le timer pour retarder la recherche pour ne pas rechercher a chaque changement
        // mais quand l'utilisateur à finit d'entrer ce qu'il veut rechercher
        timerRecherche.Stop();
        timerRecherche.Start();
    }

    private void TimerRecherche_Tick(object sender, EventArgs e)
    {
        timerRecherche.Stop();

        var request = new JobOfferFindRequest() { Id_Region = jobOfferFindRequest.Id_Region, Id_Department = jobOfferFindRequest.Id_Department, Id_City = jobOfferFindRequest.Id_City, SearchString = tBSearch.Text };
        jobOfferFindRequest = request;

        RefreshJobOffers();
    }

    private void btAdd_Click(object sender, EventArgs e)
    {
        using var formJobOffer = Program.ServiceProvider?.GetRequiredService<FormJobOffer>();

        formJobOffer?.ShowDialog();
        RefreshJobOffers();
    }

    private void btUpdate_Click(object sender, EventArgs e)
    {
        using var formJobOffer = Program.ServiceProvider?.GetRequiredService<FormJobOffer>();

        formJobOffer!.JobOffer = jobOfferBS.Current as JobOfferFindResponse;
        formJobOffer?.ShowDialog();
        RefreshJobOffers();
    }

    private void FormJobChannel_Load(object sender, EventArgs e)
    {
        RefreshData();
    }

    private void BtDelete_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Voulez-vous vraiment supprimer l'annonce ?", "Suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

        if (result == DialogResult.OK && jobOfferBS.Current is JobOfferFindResponse jo)
        {
            DeleteJobOffer(jo.Id);
        }
    }

    private void btResetFilters_Click(object sender, EventArgs e)
    {
        cbRegion.SelectedIndex = 0;
        cBJob.SelectedIndex = 0;
        cBContract.SelectedIndex = 0;

        departments.Clear();
        cities.Clear();

        cbDepartment.Enabled = false;
        cbCity.Enabled = false;

        jobOfferFindRequest = new JobOfferFindRequest();

        tBSearch.Text = string.Empty;
        RefreshJobOffers();
    }

    private void jobOfferBS_CurrentChanged(object sender, EventArgs e)
    {
        if (jobOfferBS.Current is JobOfferFindResponse)
        {
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
        }
        else
        {
            btDelete.Enabled = false;
            btUpdate.Enabled = false;
        }
    }

    private void dGVJobOffers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        using var formJobOffer = Program.ServiceProvider?.GetRequiredService<FormJobOffer>();

        formJobOffer!.JobOffer = jobOfferBS.Current as JobOfferFindResponse;
        formJobOffer?.ShowDialog();
        RefreshJobOffers();
    }
}