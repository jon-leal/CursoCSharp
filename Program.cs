﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },
                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
                {"Usando Return - Estruturas de Controle", UsandoReturn.Executar },
                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                {"Params - Classes e Métodos", Params.Executar },
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Get & Set - Classes e Métodos", GetSet.Executar },
                {"Props - Classes e Métodos", Props.Executar },
                {"Readonly - Classes e Métodos", Readonly.Executar },
                {"Enum - Classes e Métodos", ExemploEnum.Executar },
                {"Struct - Classes e Métodos", Struct.Executar },
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar },
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parâmetro por Referência - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parâmetro Padrão - Classes e Métodos", ParametroPadrao.Executar },

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"ArrayList - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },

                // OO
                {"Herança - OO", OO.Heranca.Executar },
                {"Construtor This - OO", OO.ConstrutorThis.Executar },
                {"Encapsulamento - OO", OO.Encapsulamento.Executar },
                {"Polimorfismo - OO", OO.Polimorfismo.Executar },
                {"Abstract - OO", OO.Abstract.Executar },
                {"Interface - OO", OO.Interface.Executar },
                {"Sealed - OO", OO.Sealed.Executar },

                // Metodos e Funcoes
                {"Exemplo Lambda - Metodos e Funcoes", MetodosEFuncoes.ExemploLambda.Executar },
                {"Lambda Delegate - Metodos e Funcoes", MetodosEFuncoes.LambdaDelegate.Executar },
                {"Usando Delegates - Metodos e Funcoes", MetodosEFuncoes.UsandoDelegates.Executar },
                {"Delegates com Funções Anônimas - Metodos e Funcoes", MetodosEFuncoes.DelegateFunAnonima.Executar },
                {"Delegates como Parâmetros - Metodos e Funcoes", MetodosEFuncoes.DelegatesComoParametros.Executar },
                {"Métodos de Extensão - Metodos e Funcoes", MetodosEFuncoes.MetodosDeExtensao.Executar },
                
                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },

                // API
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar },
                {"Lendo Arquivos - API", LendoArquivos.Executar },
                {"Exemplo FileInfo - API", ExemploFileInfo.Executar },
                {"Diretórios - API", Diretorios.Executar },
                {"Exemplo DirectoryInfo - API", ExemploDirectoryInfo.Executar },
                {"Exemplo Path - API", ExemploPath.Executar },
                {"Exemplo DateTime - API", ExemploDateTime.Executar },
                {"Exemplo TimeSpan - API", ExemploTimeSpan.Executar },

                // Tópicos Avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar },
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar },
                {"Nullables - Tópicos Avançados", Nullables.Executar },
                {"Dynamics - Tópicos Avançados", Dynamics.Executar },
                {"Genéricos - Tópicos Avançados", Genericos.Executar },
                                                                                                                                              
                                                              


                
            });

            central.SelecionarEExecutar();
        }
    }
}