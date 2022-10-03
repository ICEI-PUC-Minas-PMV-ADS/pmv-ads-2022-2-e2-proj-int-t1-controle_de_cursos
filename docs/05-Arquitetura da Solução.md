# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

![Diagrama de Classes - Aplicação "Controle de Cursos"](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t1-controle_de_cursos/blob/desenvolvimento/Diagrama%20de%20classes%20-%20Controle%20de%20Cursos_v2.jpeg))

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Sugestão de ferramentas para geração deste artefato: LucidChart e Draw.io.

A referência abaixo irá auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

![Modelo ER](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t1-controle_de_cursos/blob/desenvolvimento/Diagrama%20ER1.png)

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
Para mais informações, consulte o microfundamento "Modelagem de Dados".

ARQUITETURA DA SOLUÇÃO
Nesta seção são apresentados os detalhes técnicos da solução criada pela equipe, tratando dos componentes que fazem parte da solução e do ambiente de hospedagem da solução.

Diagrama de Componentes
Os componentes que fazem parte da solução são apresentados na Figura abaixo:
 
![Diagrama de Classes - Aplicação "Controle de Cursos"](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t1-controle_de_cursos/blob/desenvolvimento/Diagrama%20de%20classes%20-%20Controle%20de%20Cursos_v2.jpeg)) 

A solução implementada conta com os seguintes módulos:
•	Navegador – Local da interface básica do sistema, onde será processado todos elementos estruturais das páginas requisitadas na Web, tais como: arquivos (HTML, CSS, JavaScript), imagens e vídeos que implementam as funcionalidades do sistema.
•	Implantação - Local de armazenamento do código-fonte, onde a aplicação será colocada no ar, ou seja, é disponibilizada para uso, seja em um ambiente de desenvolvimento, de teste ou em produção.
●	Hospedagem - local de armazenamento dos arquivos estáticos que compõem as páginas web, requisitadas através dos navegadores. 
●	Banco de Dados – Local de armazenamento das informações processadas na aplicação e que retornam as requisições geradas nos navegadores.

Implantação
O site utiliza a plataforma do Heroku como ambiente de implantação do site do projeto. O site é mantido no ambiente da URL: https://www.heroku.com/home

A publicação do site no Heroku é feita por meio de uma submissão do projeto (push) via Github para o repositório remoto que se encontra no endereço: 
https://git.heroku.com/link_exemplo.git


Hospedagem
“O Amazon Simple Storage Service (Amazon S3) é um serviço de armazenamento de objetos que oferece escalabilidade, disponibilidade de dados, segurança e performance líderes do setor. Clientes de todos os portes e setores podem armazenar e proteger qualquer quantidade de dados de praticamente qualquer caso de uso, como data lakes, aplicações nativas da nuvem e aplicações móveis. Com classes de armazenamento econômicas e recursos de gerenciamento fáceis de usar, você pode otimizar custos, organizar dados e configurar controles de acesso ajustados para atender a requisitos específicos de negócios, organizacionais e de conformidade”. Fonte: Amazon -  https://aws.amazon.com/pt/s3/


Banco de Dados
O PostgreSQL trata-se de um SGBD relacional, orientado a objetos, no qual objetos definidos pelo usuário e a abordagem de tabela são combinados para criar estruturas mais complexas de dados. Ele pode lidar com qualquer carga de trabalho, tanto para produtos de máquina única quanto para aplicativos complexos, e apresenta algumas vantagens:
•	Escalável - A escalabilidade vertical é um recurso do PostgreSQL. Como quase todas as soluções de software personalizadas tendem a crescer, resultando na expansão do banco de dados, essa opção oferece suporte ao crescimento e ao desenvolvimento dos negócios muito bem.
•	Suporte para tipos de dados personalizados - O PostgreSQL suporta nativamente um grande número de tipos de dados padrão, como JSON, XML, etc. O PostgreSQL obtém vantagem disso, pois é um dos poucos bancos de dados relacionais que oferece forte suporte para a funcionalidade NoSQL. Além disso, permite que os usuários definam seus próprios tipos de dados. 
•	Ferramentas de terceiros fáceis de integrar - O sistema de gerenciamento de banco de dados PostgreSQL oferece suporte a ferramentas adicionais, tanto gratuitas quanto comerciais. 
•	Código aberto e comunidade - É totalmente de código aberto e apoiado por uma comunidade, o que o fortalece como um ecossistema completo. Além disso, os desenvolvedores sempre podem contar com o suporte rápido e gratuito da comunidade.


## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
