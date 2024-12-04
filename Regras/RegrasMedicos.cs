/*
*	<copyright file="TrabalhoPOO_Simples.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/2/2024 12:20:26 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoPOO_Simples
{
    public enum PERMISSOES
    {
        None = 0,
        Low = 1,
        High = 2,
    }
    /// <summary>
    /// Purpose:
    /// Created by: gonca
    /// Created on: 12/2/2024 12:20:26 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public static class RegrasMedicos
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
        /// Constrói uma nova instância da exceção <see cref="RegrasMedicosException"/>.
        /// </summary>
        /// <param name="perm">Permissao do utilizador.</param>
        /// <param name="medicos">Lista de medicos</param>
        /// <param name="nome">Nome do médico</param>
        /// <param name="dataN">Nome do médico</param>
        /// <param name="nif">Nome do médico</param>
        /// <param name="morada">Nome do médico</param>
        /// <param name="crm">Nome do médico</param>
        /// <param name="especialidade">Nome do médico</param>
        /// <returns>
        /// -1: Nome Incorreto
        ///  1: Valido
        /// </returns>
        public static int CriaEAdicionaMedicoLista(PERMISSOES perm, Medicos medicos, string nome, DateTime dataN, int nif, Morada morada, int crm, ESPECIALIDADE especialidade)
        {
            Medico medico;
            switch (perm)
            {
                case PERMISSOES.None:
                    return -1;
                case PERMISSOES.Low:
                case PERMISSOES.High:
                    try 
                    {
                        medico = new Medico(nome, dataN, nif, morada, crm, especialidade);
                        medicos.AdicionarMedico(medico);                                    
                    }
                    catch (MedicoException me)
                    {
                        throw me;
                    }
                    catch (ListaMedicosException lme)
                    {
                        throw lme;
                    }
                    catch(RegrasMedicosException rme)
                    {
                        throw rme;    
                    }
                    return 1;
                default:
                    return -2;
            }
        }

        public static bool RemoveMedicoLista(PERMISSOES perm, Medicos medicos, int crm)
        {
            switch (perm)
            {
                case PERMISSOES.None:
                case PERMISSOES.Low:
                    throw new RegrasMedicosException("O utilizador não tem permissões de remoção.");
                
                case PERMISSOES.High:
                    try
                    {
                        medicos.RemoverMedico(crm);
                    }
                    catch (RegrasMedicosException rme)
                    {

                    }
                    break;
                default:
                    throw new RegrasMedicosException("Permissão inválida fornecida.");
            }
            return true;
        }

        public static bool EditarMedicoLista(PERMISSOES perm, Medicos medicos, int crm, string novoNome, DateTime novaDataN, int novoNif, Morada novaMorada, int novoCrm, ESPECIALIDADE novaEspecialidade)
        {
            switch (perm)
            {
                case PERMISSOES.None:
                    throw new RegrasMedicosException("O utilizador não tem permissões de edição.");

                case PERMISSOES.Low:
                case PERMISSOES.High:
                    try
                    {
                        medicos.RemoverMedico(crm);
                    }
                    catch (RegrasMedicosException rme)
                    {

                    }
                    break;
                default:
                    throw new RegrasMedicosException("Permissão inválida fornecida.");
            }
            return true;
        }

        public static List<object> PesquisaMedicos(Medicos medicos, ESPECIALIDADE especialidade, PERMISSOES permissoes)
        {
            if (medicos == null)
                throw new RegrasMedicosException("A referência ao objeto não pode ser nula.");

            switch (permissoes)
            {
                case PERMISSOES.None:
                    throw new RegrasMedicosException("O utilizador não tem permissões de consulta.");

                case PERMISSOES.Low:
                    // Retorna uma lista de MiniMedico para permissões Low
                    return medicos.ObterMiniMedicoFiltro(especialidade).Cast<object>().ToList();

                case PERMISSOES.High:
                    // Retorna uma lista de Medico para permissões High
                    return medicos.ObterMedicoFiltro(especialidade).Cast<object>().ToList();

                default:
                    throw new RegrasMedicosException("Permissão inválida fornecida.");
            }
        }
        #endregion
        #endregion
    }
}
