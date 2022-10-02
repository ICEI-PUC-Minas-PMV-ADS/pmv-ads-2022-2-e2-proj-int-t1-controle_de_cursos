
# Metodologia

A metodologia contempla as definições das ferramentas utilizadas pela equipe tanto para a manutenção dos códigos e dos demais artefatos quanto para a organização do time na execução das tarefas do projeto.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `desenvolvimento`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

## Gerenciamento de Projeto

### Divisão de Papéis

A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento.

A equipe está organizada da seguinte maneira:

- Scrum Master: Renato
- Product Owner: Renato
- Equipe de Desenvolvimento: Pedro, Rafael A, Rafael P, Renato, Robert, Vitor
- Equipe de Design: Pedro, Rafael A, Rafael P, Renato, Robert, Vitor

### Processo

Para organização e distribuição das tarefas do projeto, a equipe está utilizando o Github estruturado com as seguintes listas:

- Product Backlog: recebe as tarefas a serem trabalhadas e representa o Product Backlog. Todas as atividades identificadas no decorrer do projeto também devem ser incorporadas a esta lista.
- To Do: Esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos trabalhando.
- Doing: Quando uma tarefa tiver sido iniciada, ela é movida para cá.
- Test: Checagem de Qualidade.
- Done: nesta lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontos para ser entregues ao usuário. Não há mais edições ou revisões necessárias, ele está agendado e pronto para a ação.
- Locked: Quando alguma coisa impede a conclusão da tarefa, ela é movida para esta lista juntamente com um comentário sobre o que está travando a tarefa.

O quadro kanban do grupo no Github está disponível através da URL https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/93 e é apresentado, na Figura abaixo:

![](/docs/img/Screenshot_1.jpg)

### Ferramentas

As ferramentas empregadas no projeto são:

| Ambiente | Plataforma | Link de acesso |
|----------|------------|------------|
| Repositório de código fonte | Github | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t1-controle_de_cursos |
| Documentos do projeto | GitHub | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t1-controle_de_cursos |
| Gerenciamento do Projeto | GitHub | https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/93/views/1 |
| Reuniões de discussão | Microsoft Teams | [l1nq.com/NzCYC ](https://l1nq.com/NzCYC)|
| Acompanhamentos diários do andamento de atividades | WhatsApp | Grupo do projeto no WhatsApp |
| Projeto de Interface e Wireframes | Figma | 
| Edição e Compilação de Código Fonte | Visual Studio Comunity 2022 | |
| Banco de Dados Relacional | SQL Server | |

Para o repositório de código fonte, gerenciamento do projeto, bem como para armazenamento e alteração dos documentos do projeto será utilizado o GitHub, instrumento robusto e amplamente usado no mercado. Para o projeto de interface e Wireframes, será utilizado o Figma, um editor online de gráficos com ênfase em prototipagem. Além disso, a comunicação ágil do grupo para acompanhamento diário das atividades se dará pelo uso da rede WhatsApp, enquanto as reuniões de discussão serão pelo Microsoft Teams.

O projeto será codificado utilizando a IDE Visual Studio Comunity 2022 com o SDK do .NET6 fazendo uso do ASP.NET Core MVC que nos possibilita criar um site dinâmico com acesso a dados de forma simples e intuitiva e com reaproveitamento de código. O Entity Framework Core será usado como ORM de acesso ao banco de dados e para o mapeamento e geração do banco de dados usaremos a técnica 'Code First', que consiste em escrever os Modelos de Entidades que representam tabelas do banco de dados e partir dos modelos gerar o banco de dados com seus respectivos relacionamentos entre entidades. Essa abordagem também nos permite manter um controle de versão sobre a evolução do banco de dados, novas tabelas e propriedades criadas utilizando o 'Migration'. 

