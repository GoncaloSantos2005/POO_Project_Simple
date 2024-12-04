/*
*	<copyright file="TrabalhoPOO_Simples.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/4/2024 10:55:25 AM</date>
*	<description></description>
**/
using System;

namespace TrabalhoPOO_Simples
{
    /// <summary>
    /// Purpose:
    /// Created by: gonca
    /// Created on: 12/4/2024 10:55:25 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public static class ValidarMedico
    {
        #region Attributes
        #endregion

        #region Methods

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Verifica os campos de um objeto médico
        /// </summary>
        /// <param name="outroMedico">Outro objeto Medico para comparação.</param>
        /// <returns>
        /// -1: Nome Incorreto
        /// -2: Idade Incorreta
        /// -3: NIF Inválido
        /// -4: Morada Inválida
        /// -5: CRM Inválido
        /// -6: Especialidade Inválida
        ///  1: Valido
        /// </returns>
        public static int ValidarCamposMedico(string nome, DateTime dataN, int nif, Morada morada, int crm, ESPECIALIDADE especialidade)
        {
            if (string.IsNullOrEmpty(nome))
                return -1;

            if (dataN > DateTime.Now.AddYears(-18))
                return -2;

            if (nif <= 0 || nif.ToString().Length != 9)
                return -3;

            if (morada == null)
                return -4;

            if (crm <= 0)
                return -5;

            if (!Enum.IsDefined(typeof(ESPECIALIDADE), especialidade))
            {
                return -6;
            }
            return 1;
        }
        #endregion
    }
}
