# PoC .NET - Handling TOML

[![wakatime](https://wakatime.com/badge/github/GuilhermeStracini/POC-dotnet-toml-handling.svg)](https://wakatime.com/badge/github/GuilhermeStracini/POC-dotnet-toml-handling)
[![Maintainability](https://api.codeclimate.com/v1/badges/f467b4bdcd3b2e6fcf68/maintainability)](https://codeclimate.com/github/GuilhermeStracini/POC-dotnet-toml-handling/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/f467b4bdcd3b2e6fcf68/test_coverage)](https://codeclimate.com/github/GuilhermeStracini/POC-dotnet-toml-handling/test_coverage)
[![CodeFactor](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-dotnet-toml-handling/badge)](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-dotnet-toml-handling)
[![GitHub license](https://img.shields.io/github/license/GuilhermeStracini/POC-dotnet-toml-handling)](https://github.com/GuilhermeStracini/POC-dotnet-toml-handling)
[![GitHub last commit](https://img.shields.io/github/last-commit/GuilhermeStracini/POC-dotnet-toml-handling)](https://github.com/GuilhermeStracini/POC-dotnet-toml-handling)
[![Build](https://github.com/GuilhermeStracini/POC-dotnet-toml-handling/actions/workflows/build.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-dotnet-toml-handling/actions/workflows/build.yml)
[![Linting](https://github.com/GuilhermeStracini/POC-dotnet-toml-handling/actions/workflows/linter.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-dotnet-toml-handling/actions/workflows/linter.yml)

🔬 Proof of Concept of handling TOML format (write/read/manipulating) using some C# libraries.

---

## Useful links

- https://toml.io/en/
- https://learnxinyminutes.com/docs/toml/

---
## Using Tommy Library

The `Tommy` library can be used to parse TOML configuration files with ease. Below is a basic example:

```csharp
using Tommy;
using System.IO;
using System;
```

## Examples

- **Reading a TOML String**

```csharp
string toml = @"
[example]
key = ""value""
";
using var reader = new StringReader(toml);
var table = TOML.Parse(reader);
Console.WriteLine($""Key: {table[""example""][""key""].AsString}"");
```

Refer to the [Tommy documentation](https://github.com/dezhidki/Tommy) for more details.

## Libraries

- [Tommy](https://github.com/dezhidki/Tommy)
- [Tomlyn](https://github.com/xoofx/Tomlyn)

## Results

### ❓ Tommy

Add results or findings related to the Tommy library here.

### ❓ Tomlyn

Add results or findings related to the Tomlyn library here.
