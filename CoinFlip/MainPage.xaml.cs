namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
                private void PlayBtn_Clicked(object sender, EventArgs e)
                {
                    Moeda moeda = new Moeda();
                    moeda.SortearLado();
                    String Selecao = FlipPicker.SelectedItem.ToString();
                    if (Selecao == moeda.LadoSorteado)
                    {
                        ResultadoLabel.Text = $"Parabéns, você pediu {Selecao} e deu {moeda.LadoSorteado}!";
                    }
                    else
                    {
                        ResultadoLabel.Text = $"Que pena, você pediu {Selecao} e deu {moeda.LadoSorteado}!";
                    }
                    CoinImage.Source = $"{moeda.LadoSorteado}.png";
                }
            }
        }
    

