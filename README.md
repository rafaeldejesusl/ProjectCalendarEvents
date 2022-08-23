# Boas-vindas ao repositório do projeto Calendário de eventos


Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes para estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório.

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project-calendar-events.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project-calendar-events`

  2. Instale as dependências.
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`.

  - Certifique-se de que você está na branch `master`.
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`.
    - Exemplo: `git checkout master`
  - Agora, crie uma branch à qual você vai submeter os `commits` do seu projeto.
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-csharp-0x-project-calendar-events`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`.

  - Verifique que as mudanças ainda não estão no _stage_.
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git.
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial.
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo esta:  _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto.

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-csharp-0x-project-calendar-events`

  6. Crie um novo `Pull Request` _(PR)_.

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project-calendar-events/pulls).
  - Clique no botão verde _"New pull request"_.
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**.
  - Coloque um título para a sua _Pull Request_.
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_.
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_.
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project-calendar-events/pulls) e verifique que o seu _Pull Request_ está criado.

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente.

  - Lembre-se sempre, após um (ou alguns) `commits`, de atualizar o repositório remoto.

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contenha `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/PsefzL2e)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Sua empresa está passando por problemas de gestão de tempo, e você prontamente propõe implementar um sistema de calendário para organização dos eventos do dia.

Aprovada sua ideia, é hora de partir para o protótipo funcional. Nesse projeto você deverá implementar um sistema que usa os tipos avançados do C# para construir um calendário de eventos para sua empresa.
 
 > Aviso: InlineData vazios fazem com que os testes somente executem se tiver alguma coisa passada por parâmetro.
  
## Armazenar informações do Evento e seus testes
`Crie sua lógica em src/calendar-events/Event.cs`

<details>
  <summary><bold>Requisito 1 e 2</bold> - Crie os construtores da classe Event</summary><br />

Complete a classe `Event`, localizada em `src/calendar-events/IEvent.cs`, para que ela implemente a interface IEvent.
  
A classe Event deve ter dois construtores.

Um com os seguintes campos: `string title`, `string date` e `string description`.

E o outro com apenas `string title`, `string date`.

A data deve ser convertida de string para o tipo `DateTime`

>  Crie os testes do construtor em `src/calendar-events.Test/TestReq1.cs`

</details>

<details>
  <summary><bold>Requisito 3</bold> - Implemente a função DelayDate</summary><br />

A função deve receber um número de dias de formato inteiro e atrasar a data do evento com essa quantidade de dias.

> Crie os testes do DelayDate em `src/calendar-events.Test/TestReq1.cs`

</details>

<details>
  <summary><bold>Requisito 4</bold> - Implemente a função PrintEvent</summary><br />

A função deve receber por parâmetro o formato de impressão do evento, e as entradas serão "detailed" ou "normal".

- Se for passada a string "normal", a função deve retornar um relatório em formato string conforme o seguinte:

"Evento = <NOME DO EVENTO>
Date = <DATA DO EVENTO NO FORMATO "d">

"


- Se for passada a string "detailed", a função deve retornar um relatório em formato string conforme o seguinte:
  
"Evento = <NOME DO EVENTO>
Date = <DATA DO EVENTO NO FORMATO "d">
Description = <DESCRIÇÃO DO EVENTO>
"

> Crie os testes do Print em `src/calendar-events.Test/TestReq1.cs`

</details>

## Criar uma coleção de Eventos e seus testes
`Crie sua lógica em src/calendar-events/EventList.cs`

<details>
  <summary><bold>Requisito 5 e 6</bold> - Implemente duas funções de busca para eventos</summary><br />

  Adapte a lista genérica criada nessa seção para uma lista de eventos, onde os nós devem armazenar uma instância do tipo `Event` e trabalhar sob esse tipo.
    Adapte os métodos .Add(), .Print() e .Index() para trabalharem com objetos do tipo `Event`
  
Implemente a função SearchByTitle(), que recebe o título de um evento por parâmetro e deve retornar o índice desse evento na lista.

Implemente a função SearchByDate(), que recebe a data de um evento por parâmetro e deve retornar o primeiro evento nessa data na lista.

>Crie os testes para as datas em `scr/calendar-events.Test/TestReq2.cs`

</details>

Com este projeto, você aprenderá a manipular tipos avançados do C# em um contexto real de datas, muito comum no dia a dia de uma pessoa desenvolvedora.
