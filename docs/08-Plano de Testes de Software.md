# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Este documento descreve os requisitos a serem testados, os tipos de testes definidos para cada iteração, os recursos a serem empregados e o cronograma dos testes ao longo do projeto. 

Os requisitos para realização dos testes de software são:

* Site publicado na Internet 
* Navegador da Internet - Chrome, Firefox ou Edge 
* Conectividade de Internet para acesso às plataformas (APISs) 

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

|**Caso de Teste**|**Teste 01**|
| :-: | :-: |
|**Requisitos Associados**|Tela "Home" e acesso a página login para alunos já cadastrados. |
|**Objetivo do Teste**|Usuário conseguir efetuar login no sistema.|
||**Passos**|
||1) Acessar o Navegador.|
||2) Informar o endereço do Site: |
||3)	Selecionar no menu a opção “ENTRAR”|
||4) Inserir usuário e senha|
||5) Clicar em “ACESSAR"|
|**Critérios de Êxito**|Após clicar em enviar deverá aparecer o nome do usuário no canto superior direito.|


|**Caso de Teste**|**Teste 02**|
| :-: | :-: |
|**Requisitos Associados**|Acesso à página de cadastro de servidores efetivos e comissionados (alunos). |
|**Objetivo do Teste**|Sistema solicitar informações para cadastro e efetuar login com o novo cadastro.|
||**Passos**|
||1) Acessar o Navegador.|
||2) Informar o endereço do Site: |
||3)	Selecionar no menu a opção “CADASTRAR”|
||4)	Inserir dados solicitados no formulário|
||5) Clicar em “SALVAR"|
|**Critérios de Êxito**|Após clicar em SALVAR deverá aparecer a mensagem "Cadastro efetuado com sucesso" e o usuário ficará logado no sistema.|


|**Caso de Teste**|**Teste 03**|
| :-: | :-: |
|**Requisitos Associados**|Visualização de cursos disponíveis para usuário logado. |
|**Objetivo do Teste**|Usuário deve conseguir visualizar e acessar os cursos disponíveis.|
||**Passos**|
||1) Acessar o Navegador.|
||2) Informar o endereço do Site: |
||3)	Efetuar “LOGIN”|
||4)	Após o login o site mostra os cursos disponíveis|
||5) Clicar em um dos cursos|
||6)	O site informa a descrição do curso e duração|
||7)	Usuário clica no botão “INICIAR”|
|**Critérios de Êxito**|Após clicar em “INICIAR” deverá começar o curso e este ficará com o status “EM ANDAMENTO”.|


|**Caso de Teste**|**Teste 04**|
| :-: | :-: |
|**Requisitos Associados**|Disponibilizar ao usuário escolha conforme categoria: cursos externos e cursos internos.|
|**Objetivo do Teste**|Usuário selecionar categoria do curso.|
||**Passos**|
||1) Acessar o Navegador.|
||2) Informar o endereço do Site: |
||3)	Efetuar “LOGIN”|
||4)	Selecionar no menu “CURSOS” > “CURSOS INTERNOS”|
||5) Sistema exibe os cursos desenvolvidos pelos próprios servidores|
||6)	Selecionar no menu “CURSOS” > “CURSOS EXTERNOS”|
||7)	Sistema exibe os cursos em parceria com instituições de ensino e contratados por meio de licitação|
|**Critérios de Êxito**|Usuário conseguir visualizar cursos de acordo com a categoria desejada.|


|**Caso de Teste**|**Teste 05**|
| :-: | :-: |
|**Requisitos Associados**|Cadastro específico para o fornecedor de curso externo.|
|**Objetivo do Teste**|Fornecedor conseguir efetuar login no sistema.|
||**Passos**|
||1) Acessar o Navegador.|
||2) Informar o endereço do Site: |
||3)	Selecionar no menu a opção “CADASTRAR”|
||4)	Inserir dados solicitados no formulário|
||5) Clicar em “ENVIAR"|
|**Critérios de Êxito**|Após clicar em enviar deverá aparecer o nome do fornecedor no canto superior direito.|


|**Caso de Teste**|**Teste 06**|
| :-: | :-: |
|**Requisitos Associados**|Fornecedor efetuar o cadastramento das propostas de cursos.|
|**Objetivo do Teste**|Fornecedor conseguir enviar a documentação necessária para o cadastramento das propostas de cursos.|
||**Passos**|
||1) Acessar o Navegador.|
||2) Informar o endereço do Site: |
||3)	Efetuar “LOGIN”|
||4)	Selecionar no menu “FORNECEDORES” > “NOVO CURSO”|
||5)	Inserir dados solicitados no formulário e anexar arquivos se for o caso|
||6)	Clicar em “ENVIAR”|
|**Critérios de Êxito**|Após clicar em enviar deverá aparecer a confirmação de que a proposta foi enviada.|


|**Caso de Teste**|**Teste 07**|
| :-: | :-: |
|**Requisitos Associados**|Fornecer página com histórico das solicitações já realizadas pelo aluno.|
|**Objetivo do Teste**|Usuário acessar cursos já finalizados ou em andamento.|
||**Passos**|
||1) Acessar o Navegador.|
||2) Informar o endereço do Site: |
||3)	Efetuar “LOGIN”|
||4)	Selecionar no menu “CURSOS” > “MEUS CURSOS”|
||5)	Sistema exibe os cursos já finalizados e em andamento|
||6)	Usuário seleciona algum curso em exibição|
||7)	O site informa a descrição do curso e duração|
||8)	Usuário clica no botão “INICIAR”|
|**Critérios de Êxito**|Após clicar em “INICIAR” deverá começar o curso caso seja um curso finalizado ou continuar de onde parou caso seja um curso em andamento.|


> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
