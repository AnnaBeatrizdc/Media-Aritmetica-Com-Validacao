# Média Aritmética com Validação
## 📋 Descrição
Aplicação Windows Forms desenvolvida em C# para calcular a média aritmética de 4 notas com validação completa de entrada de dados. O sistema garante que todos os campos sejam preenchidos corretamente e que os valores sejam numéricos e maiores que zero.
## ✨ Funcionalidades
- **Cálculo de Média Aritmética**: Calcula a média de 4 notas inseridas pelo usuário
- **Validação de Dados**: 
  - Verifica se todos os campos estão preenchidos
  - Valida se os valores inseridos são numéricos
  - Garante que todas as notas sejam maiores que zero
- **Interface Amigável**: Interface gráfica intuitiva com feedback de erros
- **Navegação por Teclado**: Suporte para navegação usando a tecla Enter
- **Limpeza de Dados**: Botão para limpar todos os campos e reiniciar o cálculo
## 🛠️ Tecnologias Utilizadas
- **Linguagem**: C#
- **Framework**: .NET Framework 4.7.2
- **Interface**: Windows Forms
- **IDE**: Visual Studio 2022
## 📁 Estrutura do Projeto
```
media-aritmetica-validacao/
├── Program.cs                    # Ponto de entrada da aplicação
├── Form1.cs                      # Lógica da interface principal
├── Form1.Designer.cs             # Design da interface
├── MediaAritmetica.cs            # Classe de modelo de dados
├── MediaAritmeticaBLL.cs         # Lógica de negócio e validação
├── Erro.cs                       # Classe para gerenciamento de erros
└── Properties/                   # Configurações do projeto
```
## 🏗️ Arquitetura
O projeto segue uma arquitetura em camadas:
- **Camada de Apresentação (UI)**: `Form1.cs` - Interface do usuário
- **Camada de Negócio (BLL)**: `MediaAritmeticaBLL.cs` - Validações e regras de negócio
- **Camada de Modelo**: `MediaAritmetica.cs` - Entidade de dados
- **Utilitários**: `Erro.cs` - Gerenciamento centralizado de erros
## 🚀 Como Usar
### Pré-requisitos
- Windows OS
- .NET Framework 4.7.2 ou superior
- Visual Studio 2017 ou superior (para desenvolvimento)
### Executando a Aplicação
1. Clone o repositório:
   ```bash
   git clone https://github.com/AnnaBeatrizdc/Media-Aritmetica-Com-Validacao.git
   ```
2. Abra o arquivo `media-aritmetica-validacao.sln` no Visual Studio
3. Compile e execute o projeto (F5)
### Usando a Aplicação
1. Insira as 4 notas nos campos de texto
2. Clique no botão "Calcular" ou use Enter para navegar entre os campos
3. A média será exibida no campo de resultado
4. Use o botão "Limpar" para reiniciar o cálculo
## ⚙️ Regras de Validação
A aplicação implementa as seguintes validações:
1. **Preenchimento Obrigatório**: Todos os 4 campos de notas devem ser preenchidos
2. **Formato Numérico**: Os valores devem ser números válidos (aceita ponto ou vírgula como separador decimal)
3. **Valores Positivos**: Todas as notas devem ser maiores que zero
Caso alguma validação falhe, uma mensagem de erro será exibida ao usuário.
## 📝 Exemplo de Uso
```
Nota 1: 8.5
Nota 2: 7.0
Nota 3: 9.5
Nota 4: 8.0
Média Aritmética: 8.25
```
## 🔧 Compilação
Para compilar o projeto via linha de comando:
```bash
# Build Debug
msbuild media-aritmetica-validacao.sln /p:Configuration=Debug
# Build Release
msbuild media-aritmetica-validacao.sln /p:Configuration=Release
```
## 📄 Licença
Este projeto está sob a licença especificada no arquivo [LICENSE](LICENSE).
## 👥 Autor
AnnaBeatrizdc
## 🤝 Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.
