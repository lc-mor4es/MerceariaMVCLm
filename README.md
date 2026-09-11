Perfeito! Como você colocou na pasta **`wwwroot/images`**, atualizei o código do **`README.md`** com os caminhos exatos para carregar no GitHub.

Copie e cole este conteúdo direto no seu arquivo:

```markdown
<div align="center">

# 🛒 Mercearia MVCLm

*Sistema de gerenciamento de clientes e catálogo de produtos desenvolvido em ASP.NET Core MVC.*

![.NET Core](https://img.shields.io/badge/.NET%208.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-blue?style=for-the-badge)

</div>

---

## 📌 Sobre o Projeto

O **Mercearia MVCLm** é um sistema web intuitivo e moderno criado para otimizar a gestão de um estabelecimento comercial. Ele oferece controle de **cadastros de clientes** e **gerenciamento de estoque de produtos**, contando com uma interface responsiva e organizada em cards e tabelas.

---

## 📸 Demonstração da Aplicação

### 🏠 Home / Painel Principal
> Tela inicial com atalhos e navegação simplificada para os módulos do sistema.

![Home Page](wwwroot/images/Print_home.png)

---

### 👥 Gestão de Clientes
> Tabela para visualização e controle de clientes, incluindo o status (`Ativo` / `Inativo`) e dados cadastrais.

![Lista de Clientes](/wwwroot/images/Print_clientes.png)

---

### 📦 Gestão de Produtos
> Controle completo de estoque com precificação formatada em moeda local e marcadores de quantidade.

![Lista de Produtos](MerceariaMVCLm/MerceariaMVCLm/wwwroot/images/Print_produtos.png)

---

## ✨ Funcionalidades

- **Clientes:**
  - Cadastro, edição, detalhes e exclusão (CRUD completo).
  - Exibição de Nome, E-mail, Idade e Status (`Ativo`/`Inativo`).
- **Produtos:**
  - Cadastro, edição, detalhes e exclusão (CRUD completo).
  - Controle de Descrição, Preço (R$) e Quantidade em estoque.
- **Interface & UX:**
  - Design limpo construído com **Bootstrap 5** e **Bootstrap Icons**.
  - Layout totalmente responsivo para desktop e dispositivos móveis.

---

## 🛠️ Tecnologias Utilizadas

- **Back-end:** C# com ASP.NET Core MVC
- **Front-end:** HTML5, CSS3, JavaScript, Bootstrap 5, Bootstrap Icons
- **Banco de Dados:** Entity Framework Core (SQL Server / SQLite)

---

## 🚀 Como Executar o Projeto

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/seu-usuario/MerceariaMVCLm.git](https://github.com/seu-usuario/MerceariaMVCLm.git)
   cd MerceariaMVCLm

```

2. **Restaure as dependências do projeto:**
```bash
dotnet restore

```


3. **Atualize o Banco de Dados:**
```bash
dotnet ef database update

```


4. **Execute a aplicação:**
```bash
dotnet run

```


5. **Acesse no seu navegador:**
`https://localhost:5001` ou `http://localhost:5000`

---

## 👨‍💻 Desenvolvedor

**Lucas Moraes**

*Desenvolvedor do projeto*

📧 Email: lucas.m.paixao@gmail.com

---
