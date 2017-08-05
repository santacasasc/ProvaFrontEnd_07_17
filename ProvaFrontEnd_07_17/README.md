Prova de Front-End
===============

Apresentação
----------------

A prova consiste na alteração do projeto contido nesse repositório, ele contém uma área de notícias, onde uma notícia tem uma categoria, e vários itens podendo ser um texto ou uma imagem.

O projeto é a alteração do template básico do asp.net utilizando autenticação individual.

Foi utilizado o Entity Framework, usando com a abordagem [Code Frist][1], para criação do banco e dos controles básicos via o scaffolding padrão.

O objetivo geral da prova é mostrar as atribuições básicas do dia a dia lembrando que todos os problemas foram simplificados para maior facilidade. 

----------



Parte 1
-------------

Alterar a pagina index da Home, o arquivo Base_Desk_Listagem.png encontrado na raiz do projeto, contém um esboço da ideia para desktop para a listagem das notícias, a primeira linha deve conter somente duas notícias, as demais 3, mostrando o título uma imagem e parte do primeiro texto. E quando o usuário clicar no conjunto ele será redirecionado para a página de visualização, como o link do exemplo.

Alterar a pagina visualizar da Home, o arquivo Base_Desk_Visualização.png contém o esboço para a visualização das notícias, onde mostra o título a sua categoria e os itens, cada item tem o seu modelo, seguindo o arquivo Base_Desk_Itens.png, o modelo de direita é semelhante ao de esquerda e foi omitido do desenho e o texto simples também.

Deve ser implementado um tema de cores para a página também, podem ser adicionados novos elementos para correção do layout ou da navegação.


Parte 2
-------

A partir do resultado da parte 1, corrigir a página para dispositivos moveis, afim de que todo conteúdo está visível e acessível, a quantidade de itens por linha pode ser alterada, e elementos podem ser ocultados se necessário.

Parte 3
-------

Alterar a pagina modal da Home, para que ao o usuário clicar em um noticia a mesma abra em um modal, seguindo o layout base de visualização das partes 1 e dois, utilizando o json de resposta dos links das páginas.


 Criação ou alteração dos dados de teste
=======

Caso os dados de testes forem alterados ou gerados mais lembrar que o banco utilizado é local, para que seja corrigido com os novos dados alterar o método seed da classe de configuração das migrações.

Considerações gerais
=======

O projeto deve ser entregue até as 18:00 do dia 18/08/2017, poderá ser enviado por [wetransfer][2] ou ferramenta semelhante, para o e-mail gabriel.ferreira@santacasasaocarlos.com.br ou preferencialmente criar um repositório pulico no [GitHub][3] ou semelhante e o envio do link do repositório no e-mail gabriel.ferreira@santacasasaocarlos.com.br.

Para qualquer dúvida, até mesmo em problemas ao tentar resolver as questões também entrar em contato que assim que possível será enviado algum material de apoio ou algum feedback sobre o problema apontado, também no mesmo e-mail gabriel.ferreira@santacasasaocarlos.com.br ou pelo WhatsApp +5515981301205 porem somente por mensagem ou imagens, para facilitar a documentação, lembrando que isso será positivo, pois o trabalho em equipe é fundamental.

Desejo a todos, boa sorte!

E estou ansioso para conhecê-los

[1]:https://msdn.microsoft.com/pt-br/library/hh972463.aspx
[2]:https://wetransfer.com/
[3]:https://github.com/