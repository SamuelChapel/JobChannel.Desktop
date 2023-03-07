using System.ComponentModel;
using BLL.Services.Geographic;
using BLL.Services.JobOffers;
using BLL.Services.JobOffers.Resquests;
using Region = JobChannel.Domain.BO.Region;
using Microsoft.Extensions.DependencyInjection;
using JobChannelDesktop.Forms;
using BLL.Services.Geographic.Requests;

namespace JobChannelDesktop;

public partial class FormJobChannel : Form
{
    private readonly BindingList<Region> regions;
    private readonly BindingList<DepartmentGetResponse> departments;
    private readonly BindingList<CityGetResponse> cities;

    private readonly BindingList<JobOfferFindResponse> jobOffers;

    private readonly IJobOfferService _jobOfferService;
    private readonly IGeoService _geoService;

    private JobOfferFindRequest jobOfferFindRequest;

    public FormJobChannel(IJobOfferService jobOfferService, IGeoService geoService)
    {
        regions = new();
        departments = new();
        jobOffers = new();
        cities = new();
        jobOfferFindRequest = new();

        _jobOfferService = jobOfferService;
        _geoService = geoService;

        InitializeComponent();
        InitializeBinding();
    }

    private void InitializeBinding()
    {
        regionBindingSource.DataSource = regions;

        departmentsBS.DataSource = departments;

        cityGetResponseBindingSource.DataSource = cities;

        jobOfferBS.DataSource = jobOffers;
        dGVJobOffers.DataSource = jobOfferBS;
    }

    private void RefreshData()
    {
        RefreshRegions();

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
    #endregion City

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

    private void cbRegion_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cbRegion.SelectedItem is Region r && r.Id != -1)
        {
            var request = new JobOfferFindRequest() { Id_Region = new List<int>() { r.Id }, SearchString = tBSearch.Text };
            jobOfferFindRequest = request;

            RefreshDepartments();
        }
        else
        {
            var request = new JobOfferFindRequest() { SearchString = tBSearch.Text };
            jobOfferFindRequest = request;

            cbDepartment.Enabled = false;
            departments.Clear();
        }

        cities.Clear();
        cbCity.Enabled = false;

        RefreshJobOffers();
    }

    private void cbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cbDepartment.SelectedItem is DepartmentGetResponse d && d.Id != -1)
        {
            var request = new JobOfferFindRequest() { Id_Department = new List<int>() { d.Id } };
            jobOfferFindRequest = request;

            RefreshJobOffers();

            RefreshCities();
        }
        else
        {
            cbCity.Enabled = false;
            cities.Clear();
        }
    }

    private void cbCity_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cbCity.SelectedItem is CityGetResponse c && c.Id != -1)
        {
            var request = new JobOfferFindRequest() { Id_City = new List<int>() { c.Id } };
            jobOfferFindRequest = request;

            RefreshJobOffers();
        }
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
}