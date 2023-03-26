using ByteBankADM.Funcionarios;
using ByteBankADM.Parceria;
using ByteBankADM.SistemaInterno;
using ByteBankADM.Utilitario;

#region

//Funcionario pedro = new Funcionario("123.123.123-12", 2000);
//pedro.Nome = "Pedro";
////pedro.Cpf = "123.123.123-12";
////pedro.Salario = 2000;

//Console.WriteLine("Bonificação funcionário = " + pedro.GetBonificacao());


//Diretor roberta = new Diretor("123.123.123-12");
//roberta.Nome = "Roberta";
////roberta.Cpf = "123.123.123-12";
////roberta.Salario = 5000;

//Console.WriteLine("Bonificação diretor = " + roberta.GetBonificacao());


//GerenciadorBonificacao gerenciadorBonificacao =  new GerenciadorBonificacao();
//gerenciadorBonificacao.Registrar(pedro);
//gerenciadorBonificacao.Registrar(roberta);

//Console.WriteLine(gerenciadorBonificacao.TotalBonificacao);
//Console.WriteLine("Total de funcionários = " + Funcionario.TotalFuncionarios);


//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro = " + pedro.Salario);
//Console.WriteLine("Novo salário da Roberta = " + roberta.Salario);

#endregion

void calcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer ulisses = new Designer("123345456");
    ulisses.Nome = "Ulisses";

    Diretor paula = new Diretor("123123123");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("123123");
    igor.Nome = "Igor";

    Gerente camila = new Gerente("121212");
    camila.Nome = "Camila";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de bonificação = " + gerenciador.TotalBonificacao);
}
calcularBonificacao();

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("1231231231");
    ingrid.Senha = "123";

    Gerente ursula = new Gerente("123231");
    ursula.Senha = "432";

    sistema.Login(ingrid, "123");
    sistema.Login(ursula, "123");

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "666";
    sistema.Login(caio, "666");

}
UsarSistema();