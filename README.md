# ASP.NET-Core
## Exercícios Alura da formação ASP.NET Core

![certificado-c-sharp](https://github.com/RafaelxFernandes/ASP.NET-Core/blob/master/Alura%20-%20Csharp-1.png?raw=true)

### 1 - C#: Explorando a linguagem
- ambientação no Visual Studio
- criação de projetos
- introdução à linguagem
- criação e declaração de variáveis
- limitações e tipos de variáveis
- typecast
- condicionais
- loop

### 2 - C#: Orientação a objetos
- sintaxe da classe
- criar um objeto
- manipular os valores dos campos de um objeto
- métodos que recebem parâmetros e retornam algum valor para simular os comportamentos (operações) de uma classe
- organizar a estrutura do nosso projeto usando os namespaces
- conceito de composição para criar classes compostas por outras classes
- restringir a visibilidade de campos de uma classe para que não sejam acessados de outros pontos do código
- métodos públicos para manipulação de campos privados, aplicando uma boa prática e implementando o conceito de encapsulamento de campos de uma classe
- sintaxe utilizada pelo C# para definir uma propriedade, que facilita a criação de operações para leitura e escrita de informação em um objeto
- propriedades autoimplementadas
- construtores
- métodos estáticos

### 3 - C#: Usando herança e implementando interfaces
- sobrecarga de métodos/ polimorfismo
- organização em diretórios distintos
- herança
- redefinir um comportamento escrito em uma classe base para uma classe derivada
- invocar o construtor da classe base a partir do construtor da classe derivada
- proteger propriedades usando o operador de visibilidade protected para impedir o acesso direto a uma propriedade de um objeto
- utilizar classes abstratas para definir uma classe que será modelo para criação de novas classes
-  usar métodos abstratos para definir como obrigatória a implementação de determinado comportamento em classes derivadas
- adicionar uma nova classe à hierarquia de classes já definida com a intenção de atender à uma nova demanda do projeto
- avançar na utilização da herança de classes, fazendo uma classe herdar de outra
- C# não implementa o conceito de herança múltipla
- funcionamento das interfaces na orientação a objetos, que são contratos que definem comportamentos a serem implementados pelas classes que assinam este contrato
- utilizar o padrão de nomenclatura adotada para nomeação de interfaces, aplicando a convenção que utiliza o prefixo I

### 4 - C#: Exceções
- pilha de chamadas (call stack)
- lidando com erros
- tratando exceções
- throw, ParamName e NameOf
- ArgumentException
- criar própria exceção
- StackTrace
- InnerException
- IOException
- Finally

### 5 - .NET 6: Criando uma Web API
- APIs trazem vantagens como: facilitar o consumo e disponibilização de dados e padronização
- REST é um padrão arquitetural que visa padronizar os meios de tráfego de dados
- enviar requisições para a API através de rotas padronizadas
- criar controladores, preparando a API para receber requisições
- criar um recurso em memória no sistema por meio da utilização de listas
- anotação [Required] torna obrigatório passar um parâmetro determinado
- anotação [StringLength] limita o tamanho de caracteres de uma string
- anotação [Range] limita o intervalo inferior e superior para valores numéricos
- recuperar informações da API através da criação de actions
- enviar parâmetros através da URL de requisição
- filtrar recursos para retornar para o usuário utilizando LINQ
- tornar nossos retornos mais enxutos através de conceitos de paginação
- abrir uma conexão entre a API e o banco de dados através do EntityFramework
- gerar migrations com .NET 6 e mapear nosso objeto no banco de dados
- DbContext serve como ponte e para fazer operações no banco
- injetar o DbContext em nosso controlador a fim de acessar o banco de dados
- salvar as alterações no banco de dados através do método SaveChanges()
- DTOs nos ajudam a não deixar nosso modelo de banco de dados exposto
- fazer conversões práticas entre diferentes tipos através do AutoMapper
- verbo PUT pode ser utilizado quando queremos atualizar algum recurso no sistema
- verbo PATCH também pode ser utilizado para atualizações, porém de maneira parcial
- verbo DELETE deve ser utilizado quando queremos deletar um recurso no sistema
- quando um recurso é atualizado ou removido com sucesso, devemos retornar status 204 (No Content)
- configurar o Swagger em nossa classe Program.cs
- documentar métodos através de XML

### 6 - .NET 6: Relacionando Entidades
- como criar, ler, atualizar e remover recursos no sistema
- Entity provê a capacidade de relacionar entidades dentro de um banco de dados
- através do Entity conseguimos abstrair questões de dependências entre entidades a nível de banco
- relacionamento 1:1 cria um vínculo entre uma e somente uma entidade dos dois lados
- definir a cardinalidade do relacionamento através das propriedades do modelo
- definir relações de dependência através das propriedades
- habilitar e utilizar Lazy Properties com o método UseLazyLoadingProxies()
- propriedades lazy podem ser acessadas diretamente em tempo de execução
- fazer mapeamentos mais complexos com os métodos ForMember() e MapFrom()
- um relacionamento 1:n cria um vínculo entre uma e muitas entidades
- podemos definir a cardinalidade do relacionamento através das propriedades do modelo
- valor na coluna de uma chave estrangeira deve constar na tabela dominante na relação
- relacionamento n:n cria um vínculo entre muitas e muitas entidades
- criar e customizar relacionamentos através do método OnModelCreating()
- relacionamento n:n pode ser composto por dois relacionamentos 1:n através de uma tabela auxiliar
- deleções em cascata são perigosas, pois podem apagar todos os dados de determinado fluxo em cadeia
- alterar o comportamento de deleção padrão através do DbContext
- efetuar consultas com SQL diretamente em nosso código através do método FromSqlRaw()
- efetuar consultas através do LINQ
