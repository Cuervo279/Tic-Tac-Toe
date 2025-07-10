using System.Dynamic;

namespace PrjJogoVelha
{
    public partial class frmJogoVelha : Form
    {
        Boolean jogador = false;

        int PontoO = 0;
        int PontoX = 0;

        public frmJogoVelha()
        {
            InitializeComponent();

            lblPontoO.Text = "0";
            lblPontoX.Text = "0";

        }

        private void VerificaJogador(Button botao)
        {
            if (jogador == false)
            {
                botao.Text = "X";
                jogador = true;
            }
            else if (jogador == true)
            {
                botao.Text = "O";
                jogador = false;
            }
        }

        private void PreencheCampo(Button botao)
        {
            if (string.IsNullOrEmpty(botao.Text))
            {
                VerificaJogador(botao);
                VerificaVencedor();
            }
            else
            {
                return;
            }
        }

        private void VerificaVencedor()
        {
            VerificarSequencia(btnCasa1, btnCasa2, btnCasa3);
            VerificarSequencia(btnCasa4, btnCasa5, btnCasa6);
            VerificarSequencia(btnCasa7, btnCasa8, btnCasa9);
            VerificarSequencia(btnCasa1, btnCasa4, btnCasa7);
            VerificarSequencia(btnCasa2, btnCasa5, btnCasa8);
            VerificarSequencia(btnCasa3, btnCasa6, btnCasa9);
            VerificarSequencia(btnCasa1, btnCasa5, btnCasa9);
            VerificarSequencia(btnCasa3, btnCasa5, btnCasa7);

            VerificaVelha(btnCasa1, btnCasa2, btnCasa3, btnCasa4, btnCasa5, btnCasa6, btnCasa7, btnCasa8, btnCasa9);
        }

        private void VerificarSequencia(Button a, Button b, Button c)
        {
            if (a.Text != "" && a.Text == b.Text && b.Text == c.Text)
            {
                MessageBox.Show($"VOCÊ VENCEU {a.Text}!");

                if (a.Text == "X")
                {
                    PontoX++;
                    lblPontoX.Text = PontoX.ToString();
                }
                else
                {
                    PontoO++;
                    lblPontoO.Text = PontoO.ToString();
                }

                NovoJogo();

            }
        }

        private void VerificaVelha(Button a, Button b, Button c, Button d, Button e, Button f, Button g, Button h, Button i)
        {
            if (a.Text != "" && b.Text != "" && c.Text != "" && d.Text != "" && e.Text != "" && f.Text != "" && g.Text != "" && h.Text != "" && i.Text != "")
            {
                MessageBox.Show($"XIIIIIIII DEU VELHA!");
                NovoJogo();
            }
        }

        private void btnCasa_MouseClick(object sender, MouseEventArgs e)
        {
            Button botao = sender as Button;
            PreencheCampo(botao);
        }


        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        public void NovoJogo()
        {
            btnCasa1.Text = "";
            btnCasa2.Text = "";
            btnCasa3.Text = "";
            btnCasa4.Text = "";
            btnCasa5.Text = "";
            btnCasa6.Text = "";
            btnCasa7.Text = "";
            btnCasa8.Text = "";
            btnCasa9.Text = "";

            jogador = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PontoX = 0;
            lblPontoX.Text = "0";

            PontoO = 0;
            lblPontoO.Text = "0";
        }
    }
}
