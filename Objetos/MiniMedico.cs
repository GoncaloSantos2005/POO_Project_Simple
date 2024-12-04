/*
*	<copyright file="TrabalhoPOO_Simples.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/2/2024 12:29:51 PM</date>
*	<description></description>
**/
using System;

namespace TrabalhoPOO_Simples
{
    /// <summary>
    /// Purpose:
    /// Created by: gonca
    /// Created on: 12/2/2024 12:29:51 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class MiniMedico
    {
        #region Attributes
        string nome;
        ESPECIALIDADE especialidade;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public MiniMedico()
        {
        }

        public MiniMedico(string nome, ESPECIALIDADE esp)
        {
            this.nome = nome;
            this.especialidade = esp;   
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~MiniMedico()
        {
        }
        #endregion

        #endregion
    }
}
