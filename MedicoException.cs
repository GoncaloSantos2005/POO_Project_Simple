/*
*	<copyright file="TrabalhoPOO_Simples.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/2/2024 10:16:12 AM</date>
*	<description></description>
**/
using System;

namespace TrabalhoPOO_Simples
{
    /// <summary>
    /// Purpose: Exceção personalizada para erros relacionados com médicos.
    /// Created by: gonca
    /// Created on: 12/2/2024 10:16:12 AM
    /// </summary>
    /// <remarks>Esta classe é usada para lançar exceções específicas quando ocorre um erro relacionado com a criação ou manipulação de objetos do tipo Médico.</remarks>
    /// <example>Exemplo de utilização:
    /// <code>
    /// try
    /// {
    ///     throw new MedicoException("O CRM do médico é inválido.");
    /// }
    /// catch (MedicoException ex)
    /// {
    ///     Console.WriteLine($"Erro: {ex.Message}");
    /// }
    /// </code></example>
    public class MedicoException : Exception
    {
        /// <summary>
        /// Constrói uma nova instância da exceção <see cref="MedicoException"/>.
        /// </summary>
        /// <param name="message">A mensagem de erro que descreve o motivo do erro.</param>
        public MedicoException(string message) : base(message) { }
    }
}
