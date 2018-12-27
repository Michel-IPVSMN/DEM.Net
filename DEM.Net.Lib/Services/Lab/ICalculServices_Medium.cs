﻿using System.Collections.Generic;

namespace DEM.Net.Lib.Services.Lab
{
    public interface ICalculServices_Medium
    {
        BeanParametresDuTin GetParametresDuTinParDefaut();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_points"></param>
        /// <returns></returns>
        BeanTopologieFacettes GetInitialisationTin(List<BeanPoint_internal> p_points, BeanParametresDuTin p_parametresDuTin);
        void AugmenteDetailsTinByRef(ref BeanTopologieFacettes p_topologieFacette, BeanParametresDuTin p_parametresDuTin);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_points"></param>
        /// <returns></returns>
        List<BeanPoint_internal> GetConvexHull2D(IEnumerable<BeanPoint_internal> p_points);
        //
        Dictionary<string, int> GetEtComptePointsDoublonnes(List<BeanPoint_internal> p_pointsToTest);
        //
        void TestMatrice(IEnumerable<BeanPoint_internal> p_points, double[] p_vecteurDeDecalage);
     }
}