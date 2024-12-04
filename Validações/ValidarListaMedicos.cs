/*
*	<copyright file="TrabalhoPOO_Simples.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/4/2024 11:27:31 AM</date>
*	<description></description>
**/
using System;

namespace TrabalhoPOO_Simples
{
    /// <summary>
    /// Purpose:
    /// Created by: gonca
    /// Created on: 12/4/2024 11:27:31 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public static class ValidarListaMedicos
    {
        #region Attributes
        #endregion

        #region Methods

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Verifica o objeto Medico
        /// </summary>
        /// <param name="medico">Objeto Medico para validação.</param>
        /// <returns>
        /// -1: Objeto Medico nulo
        ///  1: Valido
        /// </returns>
        public static int ValidarMedico(Medico medico)
        {
            if(medico == null) return -1;
            return 1;
        }

        /// <summary>
        /// Verifica o campo CRM
        /// </summary>
        /// <param name="crm">campo crm para validação.</param>
        /// <returns>
        /// -2: CRM Inválido
        ///  1: Valido
        /// </returns>
        public static int ValidarCRM(int crm)
        {
            if (crm < 0) return -2;
            return 1;
        }

        /// <summary>
        /// Verifica se a lista tem alguma informação
        /// </summary>
        /// <param name="medicos">campo crm para validação.</param>
        /// <returns>
        /// -3: Lista nula
        /// -4: Lista vazia
        ///  1: Valido
        /// </returns>
        public static int ValidarLista(Medicos medicos)
        {
            if (medicos == null) return -3;
            if (medicos.Count == 0)
                return -4;
            return 1; // Lista válida
        }

        #endregion

        #endregion
    }
}
