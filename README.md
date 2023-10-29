# MonitorStocks
Este programa tem como objetivo acompanhar a cotação de do ativo passado como parâmetro.

Além do ativo é informado Preço Máximo, no qual o usuário deseja executar a venda do ativo. Além do Preço Minímo, no qual o usuário deseja realizar a compra do ativo.

Assim que um dos paramêtros é atingido, é enviado um e-mail configurado pelo usuário sugerindo a compra ou a venda o ativo.

O promagra é executado continuamente, enquanto o terminal estiver aberto.

# Requisitos
Para que o programa possa executar sem problemas é necessário instalar o pacote Newtonsoft.Json

## Instalação
Após abrir a pasta do projeto via CMD execute o seguinte comando:
```
dotnet add package Newtonsoft.Json
```
