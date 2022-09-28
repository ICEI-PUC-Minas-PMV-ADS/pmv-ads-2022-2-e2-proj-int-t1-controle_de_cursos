# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Acesso a pagina "Home e cadastro"** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - Deve possuir tela "Home" e fornecer acesso a página de cadastro de servidores efetivos e comissionados (alunos) e também login para alunos já cadastrados. |
| Objetivo do Teste 	| Acessar a pagina "Home" e utilizar suas as funcionalidades |
| Passos 	| - Acessar o sistema <br> - Clicar em fazer cadastro (opção para servidores efetivos e alunos) <br> - Preencher os campos obrigatórios <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-01 - Deve possuir tela "Home" e fornecer acesso a página de cadastro de servidores efetivos e comissionados (alunos) e também login para alunos já cadastrados. |
| Objetivo do Teste 	| Verificar se o usuário é capaz de realizar login. |
| Passos 	| - Acessar o sistema <br> - Clicar no botão de Login <br> - Preencher o campo de CPF <br> - Preencher o campo da senha <br> - <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Visualizar opções cursos**	|
|Requisito Associado | RF-02	- Deve possibilitar o cadastro de alunos para o acesso a página home logada permitindo a visualização das ofertas de cursos disponíveis. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar as opções de cursos disponiveis. |
| Passos 	| - Fazer o login <br> - Clicar em cursos disponiveis |
|Critério de Êxito | - Visualizar as opções de cursos disponiveis. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Ver detalhes do curso desejado**	|
|Requisito Associado | RF-03	- A aplicação deve possuir a grade de programação de cursos contendo todos as informações específicas de cada curso. |
| Objetivo do Teste 	| Verificar se o usuário consegue acessar o detalhamento dos cursos. |
| Passos 	| - Fazer o login <br> - Clicar em cursos disponiveis <br> - Selecionar o curso desejado <br> - Verificar os detalhes referente ao curso <br> - Voltar a pagina de cursos |
|Critério de Êxito | - Foi possivel visualizar os detalhes do curso |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Filtrar a pesquisa de cursos de acordo com a opção desejada**	|
|Requisito Associado | RF-04	- Deve disponibilizar ao usuário as opções de escolha conforme categoria: cursos externos (parceria com instituições de ensino e contratados por meio de licitação) e cursos internos (desenvolvidos pelos próprios servidores municipais da Administração Direta (Secretarias Municipais e/ou Órgãos) ou pelos servidores das Entidades da Administração Indireta (Autarquias e/ou Fundações). |
| Objetivo do Teste 	| Verificar se o usuario consegue filtrar as opções de curso. |
| Passos 	| - Fazer o login <br> - Clicar em cursos disponiveis <br> - Selecionar o filtro de acordo com a opção de curso desejada <br> - Clicar em filtrar <br> - Verificar se o sistema retornou a opção desejada. |
|Critério de Êxito | - A pesquisa foi filtrada de acordo com a opção do usuário. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Cadastro de curso**	|
|Requisito Associado | RF-05	- Deve disponibilizar cadastro específico para o fornecedor de curso externo inserir os dados da empresa e a documentação necessária para o cadastramento das propostas de cursos, arquivos necessários à contratação, verificação documental e validação das informações cadastrais. |
| Objetivo do Teste 	| Verificar se o fornecedor de cursos é capaz de cadastrar uma opção de curso. |
| Passos 	| - Acessar o sistema <br> - Efetuar o login como fornecedor de cursos <br> - Clicar na opção de cadastrar curso <br> - Preencher os campos necessários <br> - Clicar em "Cadastrar curso" |
|Critério de Êxito | - O cadastro do curso foi efetuado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Efetuar login**	|
|Requisito Associado | RF-07	- A aplicação deve possibilitar o cadastro e registro das informações pertinentes ao processo de licitação/negociação dos cursos. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| -  <br> - <br> -  <br> -  <br> -  <br> -  |
|Critério de Êxito | -  |
|  	|  	|
| **Caso de Teste** 	| **CT-09 – Acessar historico de solicitações de cursos**	|
|Requisito Associado | RF-08	- Fornecer página com histórico das solicitações ja realizadas pelo aluno, sejam elas em andamento ou encerradas. |
| Objetivo do Teste 	| Verificar se o fornecedor de cursos é capaz de cadastrar uma opção de curso. |
| Passos 	| - Acessar o sistema <br> - Efetuar o login como aluno <br> - Clicar na opção de historico <br> - Verificar os cursos em andamento ou encerrados <br> - Voltar a pagina inicial |
|Critério de Êxito | - Verificação de historico feita com sucesso. |
|  	|  	|


 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
