# TargetInverterString

5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:

* a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
* b) Evite usar funções prontas, como, por exemplo, reverse;

### Minha abordagem

Optei por estruturar a solução onde o código está em classes, em vez de nível superior como no **Teste da Fibonacci**.

* É criado um array de caracteres do tipo **char** e inicia uma variável do tipo **int** j igual a 0.

* Com isso, criei um loop, onde **i** tem o valor do tamanho da string a ser convertida -1, se **i** for menor ou igual a 0, será decrementado, subtraído 1 de **i**.

* Tendo a satisfação do for, o índice do array do tipo **char** chamado de **array** recebe o incremento de 1 em **j**, sendo igual ao índice da String, isso tudo dentro do laço **for**, colocando os caracteres de trás pra frente.

* Saindo do faço **for**, ele retorna a string invertida para ser impressa na tela.