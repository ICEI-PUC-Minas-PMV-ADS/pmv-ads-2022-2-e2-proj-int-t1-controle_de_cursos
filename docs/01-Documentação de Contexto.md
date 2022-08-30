# Introdução

As planilhas do Excel são uma ótima ferramenta para coletar e transformar pequenas quantidades de dados. No entanto, quando se requer maiores quantidades como em projetos de coleta e administração de dados cadastrados por uma grande quantidade de usuários o programa começa a mostrar suas limitações, tais como:

- Pouca reutilização: a falta de uma forma confiável e repetitiva de coletar dados de várias fontes torna a reutilização limitada a processos muito simples.
- Escalabilidade problemática: limite de linhas que pode ser um problema com conjuntos de dados muito grandes.
- Baixa cobertura de operações de dados: quando os projetos se tornam maiores e exigem operações de dados mais sofisticadas, algumas não estão disponíveis no Excel. 
- Falta de automação: sempre que for preciso calcular novos valores será necessário reabrir o Excel, executar estas operações manuais e recalcular.
- Colaboração difícil: atualmente, nenhum cientista, programador ou engenheiro de dados trabalha sozinho. Todos fazem parte de equipes maiores ou menores e precisam se comunicar com os aplicativos que criam. Depuração da equipe, discussões de recursos, práticas recomendadas e documentação são tarefas necessárias no trabalho diário. O Excel realmente não foi criado para colaboração em grandes equipes, residindo apenas em uma máquina local.
- Consome tempo: a falta de escalabilidade, as operações manuais, as limitações na quantidade de dados tornam todo o processo em torno de uma planilha do Excel bastante demorado.

## Problema

Conforme exposto, o problema que se busca resolver com este projeto é composto pelas ineficiências em gerir, comparar, versionar e fazer backup com segurança dos dados referentes a cursos e alunos geridos em formato de planilhas feitas através do Microsoft Excel. 
A fim de facilitar a obtenção e análise dos dados cadastrados propomos a criação de um sistema que permita cadastrar alunos e cursos oferecidos por uma prefeitura com numero de colaboradores em expansão, oferecendo um cliente web para cadastro de cursos e alunos e geração de relatórios específicos de volumetria dos cursos, em conjunto com um sistema back-end com uma API que se comunicará com um banco de dados que armazenará todas as informações que antes ficavam espalhadas em planilhas.

## Objetivos

- Desenvolvimento de um sistema que ofereça uma um cliente web com uma ferramenta administrativa para cadastro de cursos e alunos que se integre com um back-end por meio de uma API para se comunicar com o banco de dados que irá persistir os dados cadastrados e relatórios gerados.
- O sistema tem a perspectiva de cobrir uma demanda crescente de colaboradores que se cadastram para realizar cursos e irá oferecer suporte necessário para escalabilidade do número de cursos e alunos que virão a ser cadastrados no futuro.
- Gerar relatórios de volumetria por curso, alunos cadastrados por curso e cursos mais realizados para assim então oferecer uma melhor análise da situação atual dos alunos para a equipe responsável por oferecer novos cursos e avaliar a qualidade dos já ofertados.

## Justificativa
  Facilitar a organização dos cursos, impedindo que haja duplicidade dos usuários.  Melhorando a comunicação entre os organizadores e os alunos inscritos. Auxiliando, dessa forma, a comunicação entre todas as partes envolvidas no processo de inscrição e organização da plataforma.


## Público-Alvo

O público-alvo deste trabalho são servidores que precisam acessar o sistema para se informar sobre os cursos disponíveis e cursos realizados e também pessoas que precisem fazer o gerenciamento do sistema. Desta forma estabeleceu-se como público-alvo servidores efetivos e servidores comissionados do município de Contagem, desenvolvedores do sistema de cursos e possíveis fornecedores de cursos tais como instituições de ensino.
