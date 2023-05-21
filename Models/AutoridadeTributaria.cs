using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Threading;

namespace SimproV
{
    public enum ErrosLigacao { SiteEmBaixo };
    public class AutoridadeTributaria
    {

        private string _nif;
        private string _senha;
        private string _mensagemErro;
        ErrosLigacao tipoerro;

        public ErrosLigacao TipoErro
        {
            get { return tipoerro; }
            set { tipoerro = value; }
        }
        public AutoridadeTributaria(string nif, string senha)
        {
            _nif = nif;
            _senha = senha;
        }

        public List<Fatura> Processar()
        {
            List<Fatura> listaDeFaturas = new List<Fatura>();
            try
            {
                Login();
                listaDeFaturas.Add(new Fatura
                {
                    NIFComerciante = "111111111",
                    Nome = "Comerciante A",
                    QtDocumentos = 10
                });
                listaDeFaturas.Add(new Fatura
                {
                    NIFComerciante = "222222222",
                    Nome = "Comerciante b",
                    QtDocumentos = 5 
                });
                listaDeFaturas.Add(new Fatura
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
            return listaDeFaturas;
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

            var loginUsername = _nif;
            var loginPassword = _senha;

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

            /*

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
