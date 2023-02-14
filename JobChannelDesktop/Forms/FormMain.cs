using BLL.Services.Geographic;
using BLL.Services.JobOffers;

namespace JobChannelDesktop;

public partial class FormMain : Form
{
    private readonly IJobOfferService _jobOfferService;
    private readonly IGeoService _geoService;

    public FormMain(IJobOfferService jobOfferService, IGeoService geoService)
    {
        _jobOfferService = jobOfferService;
        _geoService = geoService;
        InitializeComponent();
    }

    private void JobOfferBtn_Click(object sender, EventArgs e)
    {
        using var formJobOffer = new FormJobChannel(_jobOfferService, _geoService);

        Visible = false;
        formJobOffer.ShowDialog();
        Visible = true;
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
