# 🚀 Primeira Aula de C# (.NET)

Bem-vindo ao meu primeiro projeto em **C#** utilizando a plataforma **.NET**.

Este repositório marca o início da minha jornada com a linguagem C#, onde aprendi os conceitos fundamentais necessários para criar uma aplicação de console.

---

## 📚 Conteúdo estudado

### 1. Criando um projeto com .NET

Aprendi a criar aplicações utilizando a CLI do .NET.

Criando um projeto no diretório atual:

```bash
dotnet new console
```

Criando um projeto com um nome específico:

```bash
dotnet new console -n Aula1
```

Após criar o projeto, basta entrar na pasta:

```bash
cd Aula1
```

---

### 2. Estrutura básica do projeto

Conheci os principais arquivos criados automaticamente pelo .NET:

* `Program.cs` — ponto de entrada da aplicação.
* `.csproj` — arquivo responsável pela configuração do projeto.

---

### 3. Impressão de texto

Aprendi a exibir informações no terminal utilizando `Console.WriteLine()`.

```csharp
Console.WriteLine("Olá, Mundo!");
```

Também descobri que é possível imprimir variáveis e expressões.

```csharp
string nome = "Miguel";

Console.WriteLine(nome);
Console.WriteLine("Bem-vindo ao C#!");
```

---

### 4. Variáveis

Conheci alguns dos principais tipos de dados da linguagem.

```csharp
string nome = "Miguel";
int idade = 31;
double altura = 1.57;
bool estudando = true;
```

Essas variáveis permitem armazenar diferentes tipos de informações dentro do programa.

---

### 5. Comentários

Aprendi a documentar o código utilizando comentários.

Comentário de uma linha:

```csharp
// Isto é um comentário
```

Comentário de múltiplas linhas:

```csharp
/*
Este comentário
possui várias linhas.
*/
```

Comentários ajudam a explicar o funcionamento do código e facilitam sua manutenção.

---

### 6. Convenção Camel Case

Também aprendi sobre a convenção **camelCase**, utilizada para nomear variáveis e métodos.

Exemplos:

✅ Correto

```csharp
string nomeCompleto;
int idadeUsuario;
double salarioMensal;
```

❌ Evite

```csharp
string Nome_Completo;
string NOMECOMPLETO;
string nome_completo;
```

Utilizar uma convenção de nomes torna o código mais organizado e fácil de compreender.

---

## 🛠️ Tecnologias

* C#
* .NET SDK
* Visual Studio Code
* Git
* GitHub

---

## 🎯 Objetivo

Este projeto faz parte dos meus estudos de C# e .NET.

A ideia é utilizar este repositório para registrar minha evolução, praticar os conceitos aprendidos em aula e criar uma base sólida antes de avançar para Programação Orientada a Objetos, ASP.NET Core e desenvolvimento Full Stack.

---

## 📖 Próximos assuntos

* Entrada de dados (`Console.ReadLine()`)
* Conversão de tipos
* Operadores matemáticos
* Operadores lógicos
* Estruturas condicionais (`if`, `else` e `switch`)
* Estruturas de repetição (`for`, `while` e `foreach`)

---

> "Toda grande aplicação começa com um simples `Olá mundo!`."

