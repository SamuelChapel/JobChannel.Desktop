using BLL.Services.Contracts;
using BLL.Services.Geographic;
using BLL.Services.JobOffers;
using BLL.Services.Jobs;

namespace JobChannelDesktop;

public partial class FormMain : Form
{
    private readonly IJobOfferService _jobOfferService;
    private readonly IGeoService _geoService;
    private readonly IJobService _jobService;
    private readonly IContractService _contractService;

    public FormMain(IJobOfferService jobOfferService, IGeoService geoService, IJobService jobService, IContractService contractService)
    {
        _jobOfferService = jobOfferService;
        _geoService = geoService;
        _jobService = jobService;
        _contractService = contractService;
        InitializeComponent();
    }

    private void JobOfferBtn_Click(object sender, EventArgs e)
    {
        using var formJobOffer = new FormJobChannel(_jobOfferService, _geoService, _jobService, _contractService);

        Visible = false;
        formJobOffer.ShowDialog();
        Visible = true;
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
