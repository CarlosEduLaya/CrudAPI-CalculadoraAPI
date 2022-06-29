# ExecPontoCertificado
Calculadora e Funcionario

Olá pessoal da ponto certificado :), tudo bem ?

Esse projeto foi desenvolvido com banco de dados local, para facilitar a execução dele :D. Foi enviado para git o banco com dados já.

Então para executar esse projeto, precisa ter o visual studio fazer um git clone e abrir o arquivo .sln, após fazer isso e só rodar o 
iss (Lembre-se de não estar executando nada de aplicações para não dar conflito na porta) que automaticamente irá abrir o swagger onde vai ter api de funcionario e calculadora, caso de erro, 
possivelmente o .net não encontrou os pacotes do nugnet. 

Para instalar as dependencias basta clicar com botão direito >>> gerenciar pacote no NugNet >> e instalar essas depencias
![image](https://user-images.githubusercontent.com/98174354/176447991-05c4a38d-bbd5-4905-8ac1-b43c2a96c244.png)


Deu tudo certo, você verá essa imagem abrindo para ti, o 1º endpoint da calculadora e a consulta dos logs de todas as contas que você realizou o 
2º endpoint da calculadora calcula a operação que você quis fazer e salva no logs. 

Na parte dos funcionarios, eu fiz o crud o 1º endpoint lista todos funcionarios cadastrados, 2º endpoint cadastra o funcionario, 3º endpoint altera o funcionario pelo id
4º consulta o funcionario pelo cpf e o 5º deleta o funcionario pelo id
![image](https://user-images.githubusercontent.com/98174354/176448298-eb04eaa6-2e3a-4017-8087-77bb0147d90a.png)


Caso não deseja que o banco de dados esteja no projeto, basta excluir esses dois arquivos e rodar novamente.
![image](https://user-images.githubusercontent.com/98174354/176451047-18ed764e-6b05-4535-ab0c-b03e99bacfce.png)


