# MonitorStocks
Este programa tem como objetivo acompanhar a cotação de do ativo passado como parâmetro.

Além do ativo é informado Preço Máximo, no qual o usuário deseja executar a venda do ativo. Além do Preço Minímo, no qual o usuário deseja realizar a compra do ativo.

Assim que um dos paramêtros é atingido, é enviado um e-mail configurado pelo usuário sugerindo a compra ou a venda o ativo.

O promagra é executado continuamente, enquanto o terminal estiver aberto.

O programa utiliza a API: https://brapi.dev/

# Requisitos
Para que o programa possa ser executado é necessário instalar o pacote Newtonsoft.Json

Após abrir a pasta do projeto via CMD execute o seguinte comando:
```
dotnet add package Newtonsoft.Json
```

# Instalação
O projeto pode ser compilado via Visual Basic em: <em>Compilação > Compilar Solução</em>, ou via promp de comando, através do comando:
```
csc Program.cs
```
Após compilar o projeto duas pastas serão criadas no diretório do projeto. O executável ficará disponivel no diretório: 
```
C:\...\MonitorStocks\bin\Debug\net7.0\MonitorStocks.exe
```

Além disso, vamos precisar configurar  o e-mail para qual serão disparados os alertas, este devará ser configurado através do arquivo <em>SetupSMPT.txt</em>. Feitas as configurações, vamos precisar salvar o arquivo onde relizamos as configurações, no mesmo diretório onde o executável se encontra disponivel.

# Como Utilizar
Após realizar os procedimentos anteriores, podemos executar o programa via prompt de comando.

Para que o programa seja executado é necessário informar três parâmetros, sendo esses:
- Ticket da ação a ser monitorada
- Cotação Máxima (Indica call de venda do ativo)
- Cotação Miníma (Indica call de compra do ativo)

## Exemplo
Queremos monitorar a cotação de PETR4, e queremos vender o ativo, caso este atinga ou ultrapasse a cotação de R$37,00. Bem como desejamos comprar o ativo, caso este atinga uma cotação igual ou inferior a R$ 36,00.
Para isso, vamos executar o seguinte comando:
```
MonitorStocks.exe PETR4 37,00 36,00
```
Sendo assim, enquanto o programa estiver rodando, este irá enviar os e-mails de alerta de compra ou venda de acordo com os parametros informados no inicio da execução do programa.





