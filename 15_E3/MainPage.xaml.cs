namespace _15_E3;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string N = Nom.Text;
        double pkg = Convert.ToDouble(kg.Text);
        double amts = Convert.ToDouble(mts.Text);

        double pt = pkg * 2.20462;
        double at = amts * 100;

        la.Text = "EL DINOSAURIO " + N + " pesa en kg =" + pkg + " en libras =" + pt +
            " de alto en metros =" + amts + " en centimetros =" + at;
    }
}

