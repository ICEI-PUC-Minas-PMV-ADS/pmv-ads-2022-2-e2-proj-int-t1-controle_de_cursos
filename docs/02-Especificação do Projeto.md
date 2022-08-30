# Especificações do Projeto

A fim de definir de maneira minuciosa a especificação do problema e os pontos mais relevantes a serem tratados neste projeto, foram realizadas entrevistas com alunos, gestores de escolas do governo, secretarias, professores e administradores de cursos e sistemas. As entrevistas objetivaram identificar o perfil dos usuários e suas principais dificuldades.


## Personas
 
### <span style="color:Green">**`João Gomes`**


|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/Projeto-Grupo-6/blob/master/docs/img/users/joao%20gomes.png" width="150" height="100">   | **João Gomes** <br> 41 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Técnico em contabilidade, servidor comissionado do município de Contagem-BH
|**Motivação** | Investir em aprendizado para conseguir melhores ofertas de trabalho
|**Frustrações** | Pouco tempo para estudar|

### <span style="color:Green">**`Rafael Souza`**


|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/DriveMyCar/blob/master/docs/img/users/Felipe.jpg" width="160" height="100">   | **Rafael Souza** <br> 34 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Fornecedor de cursos
|**Motivação** | Aumento da qualidade e disponibilidade da educação no Brasil
|**Frustrações** | Dificuldade em achar plataformas confiáveis para cadastrar os cursos ofertados pela sua empresa, bem como seu portifólio|


### <span style="color:Green">**`José Alberto de Souza`**


|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/Projeto-Grupo-6/blob/master/docs/img/users/jose.jpg" width="150" height="100">   | **José Alberto de Souza** <br> 63 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Aposentado
|**Motivação** |Aprender, com os cursos, assuntos que não tinha tempo enquanto trabalhava.
|**Frustrações** |Dificuldade em utilizar a plataforma dos cursos disponíveis. Não conseguir se comunicar diretamente com os professores.|



  ### <span style="color:Green">**`Maria de Assis Pereira`**


|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/Projeto-Grupo-6/blob/master/maria.jpg" width="150" height="100">   | **Maria de Assis Pereira** <br> 35 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Administradora do Sistema |
|**Motivação** |Poder proporcionar condições de desenvolvimento pessoal  e capacitação profissional aos servidores; Poder apresentar ferramentas administrativas capazes de auxiliar o servidor no planejamento e  organização das atividades em seu local de trabalho; Aumentar nível de qualidade das entregas aos cidadãos, através do aumento do número de servidores capacitados e treinados. |
|**Frustrações** |Não ter um sistema que auxilie na organização das atividades operacionais da Escola de Governo; Falta de padronização das informações no local de trabalho; Dificuldade de obter informações consistentes e atualizadas; Não ter informações disponibilizadas on-line; Ter que trabalhar com planilhas eletrônicas, que necessitam de atualização manual.|

### <span style="color:Green">**`Joaquim Lara`**


|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/Projeto-Grupo-6/blob/1081f53ec7b5d6a3cd048129773603861b46c832/Joaquim%20Ribeiro.png" width="100" height="155">   | **Joaquim Lara** <br> 35 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Ponto focal da Secretaria
|**Motivação** | Administrar de forma eficiente todos os cursos que são de minha responsabilidade
|**Frustrações** | Dificuldade de acessar as informações especificas dos cursos que administro.|
  
### <span style="color:Green">**`Rosana Avelar`**


|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/Projeto-Grupo-6/blob/master/docs/img/users/Rosana.jpg" width="100" height="155">   | **Rosana Avelar** <br> 44 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Gestora da Escola de Governo
|**Motivação** | Prover qualidade e suporte aos processos e pessoas geridos na Escola de Governo
|**Frustrações** | Dificuldade de acesso a dados e relatórios de indicadores de desempenho de alunos e cursos realizados, que são vitais para tomada de decisões de negócio|


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/DESEJO ... `O QUE` |PARA ... `PORQUE`                 |
|--------------------|------------------------------------|----------------------------------------|
|José Alberto de Souza (aluno, servidor efetivo)|	Receber informações dos cursos disponíveis, poder expressar opinião e sugestões, ter canal direto ao suporte da Escola de Governo.	|Acessar e imprimir as informações resumidas de todos os cursos que realizei, acessar e imprimir todos os meus certificados|
|João (aluno, servidor comissionado)|	Receber informações dos cursos disponíveis, poder expressar opinião e sugestões, ter canal direto ao suporte da Escola de Governo.|	Acessar e imprimir as informações resumidas de todos os cursos que realizei, acessar e imprimir todos os meus atestados|
|Rafael Souza (parceiro, servidor de cursos)| Cadastrar os dados da minha empresa, cadastrar o meu portifólio de cursos.| Participar dos processos licitatórios e de contratações dos cursos|
|Maria de Assis Pereira (administradora do sistema)|	Acessar todos os dados dos alunos, acessar todos os dados dos cursos|	Controlar os acessos e permissões dos alunos, montar a grade de programação dos cursos|
|Joaquim Lara (ponto focal da secretaria/órgão/entidade)| Acessar a grade de programação dos cursos, acessar as informações de todos cursos feitos pelos servidores da minha área de acompanhamento, concentrar os contatos com os servidores em um canal de comunicação específico na plataforma|	Programar a distribuição das vagas aos servidores da minha área de responsabilidade|
|Rosana Avelar (gestora da escola de governo)|	Acessar um painel de indicadores (de desempenho dashboard) dos alunos e dos cursos realizados|	Gerar relatórios aos superiores hierárquicos e auxilia-los na tomada de decisões|
## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | ALTA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-003| O site deve estar disponível 24 horas por dia, todos os dias da semana  | ALTA |  
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge, Safari ou Ópera) | ALTA | 
|RNF-005| O site deve ter uma linguagem simples e de fácil entendimento | ALTA | 
|RNF-006| O site deve ter uma boa navegabilidade e usabilidade, facilitando a experiência do usuário | ALTA | 
|RNF-007| Por se tratar de um site com abrangência nacional o site deve comportar grandes acessos simultâneos | ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
