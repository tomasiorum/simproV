﻿namespace SimproV
{
    public enum ErrosLigacao { SiteEmBaixo };
    public class AutoridadeTributaria
    {

        private ILogin login;
        private IRespostaAT respostaAT;

        private string _mensagemErro;
        ErrosLigacao tipoerro;

        public ErrosLigacao TipoErro
        {
            get { return tipoerro; }
            set { tipoerro = value; }
        }
        public AutoridadeTributaria(ILogin login)
        {
            this.login = new Login(login);
        }

        public IRespostaAT Processar()
        {
            // Foi aplicado em HardCode porque não temos o acesso à At
            respostaAT = new RespostaAT();
            try
            {
                Login();
                respostaAT.ListaFaturas.Add(new Fatura
                {
                    NIFComerciante = "111111111",
                    Nome = "Comerciante A",
                    QtDocumentos = 10
                });
                respostaAT.ListaFaturas.Add(new Fatura
                {
                    NIFComerciante = "222222222",
                    Nome = "Comerciante b",
                    QtDocumentos = 5 
                });
                respostaAT.ListaFaturas.Add(new Fatura
                {
                    NIFComerciante = "333333333",
                    Nome = "Comerciante c",
                    QtDocumentos = 7 
                });
            }
            catch
            {
                _mensagemErro = "Erro ao efetuar login.";
                throw;
            }
            return respostaAT;
        }

        internal void SubmeterComerciante(string nif, string atividade)
        {
           // Todo Falta implementar a submissão à AT.
           // ou então remover da lista inicial fornecida ao utilizador
        }

        public string GetMensagemErro()
        {
            return _mensagemErro;
        }

        //<input type="text" name="username" id="username" title="Insira um N° de Contribuinte válido" class="customField" placeholder="Nº de Contribuinte" pattern="[0-9/]{9,14}" required="" autofocus="autofocus" aria-required="true">
        //<input type="password" class="password" name="password" spellcheck="false" title="Campo Obrigatório" id="password-nif" required="" placeholder="Senha de acesso" autofocus="autofocus" aria-required="true">
        // <button type="submit" name="sbmtLogin" id="sbmtLogin" tabindex="4" class="sa-btn1" value="Entrar">Autenticar</button>
        private void Login()
        {
            
            var loginUsername = login.NIF;
            var loginPassword = login.Senha;

            /* @Todo falta a pesquisa ao site das finanças
             * 
            FirefoxOptions options = new FirefoxOptions();
            options.AddArguments("--headless");
            Configuration.driver = new FirefoxDriver(options);



            
            Configuration.driver.Navigate().GoToUrl("http://www.selenium.academy/Examples/Interaction.html");
            SeleniumSetMethods.EnterText("textbox", loginUsername, "Id");
            Thread.Sleep(WaitTime.Ms);
            SeleniumSetMethods.SelectDropDown("combobox", "Option 2", "Id");
            SeleniumSetMethods.MouseClick("checkbox", "Id");
            IWebElement button = Configuration.driver.FindElement(By.Id("button"));

            button.Click();

            Configuration.driver.Quit();
            */

            /* Exemplo da Selelenium

            var login_page = "https://www.acesso.gov.pt/jsp/loginRedirectForm.jsp?path=painelAdquirente.action&partID=EFPF";

            Configuration.driver = new FirefoxDriver();
            TestSite.Url = login_page;
            WaitTime.Ms = 2000;
            ProjectBase.Path = System.IO.Directory.GetCurrentDirectory();


            Configuration.driver.Navigate().GoToUrl(login_page);
            var loginButton = By.Id("sbmtLogin");

            // Inicio login
            Thread.Sleep(WaitTime.Ms);
            //Configuration.driver.Manage().Window.Maximize();
            SeleniumSetMethods.EnterText("username", loginUsername, "Id");

            SeleniumSetMethods.EnterText("password-nif", loginPassword, "Id");
            Thread.Sleep(WaitTime.Ms);
            Configuration.driver.FindElement(loginButton).Click();
            Configuration.driver.wait
            Thread.Sleep(WaitTime.Ms);
            */
        }

    }
}
