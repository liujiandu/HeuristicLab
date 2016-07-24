#region License Information
/* HeuristicLab
 * Copyright (C) 2002-2016 Heuristic and Evolutionary Algorithms Laboratory (HEAL)
 *
 * This file is part of HeuristicLab.
 *
 * HeuristicLab is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * HeuristicLab is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with HeuristicLab. If not, see <http://www.gnu.org/licenses/>.
 */
#endregion

using HeuristicLab.PluginInfrastructure;

namespace HeuristicLab.Algorithms.SimulatedAnnealing {
  /// <summary>
  /// Plugin class for HeuristicLab.Algorithms.SimulatedAnnealing plugin.
  /// </summary>
  [Plugin("HeuristicLab.Algorithms.SimulatedAnnealing", "3.3.14.14190")]
  [PluginFile("HeuristicLab.Algorithms.SimulatedAnnealing-3.3.dll", PluginFileType.Assembly)]
  [PluginDependency("HeuristicLab.Analysis", "3.3")]
  [PluginDependency("HeuristicLab.Collections", "3.3")]
  [PluginDependency("HeuristicLab.Common", "3.3")]
  [PluginDependency("HeuristicLab.Core", "3.3")]
  [PluginDependency("HeuristicLab.Data", "3.3")]
  [PluginDependency("HeuristicLab.Operators", "3.3")]
  [PluginDependency("HeuristicLab.Optimization", "3.3")]
  [PluginDependency("HeuristicLab.Optimization.Operators", "3.3")]
  [PluginDependency("HeuristicLab.Parameters", "3.3")]
  [PluginDependency("HeuristicLab.Persistence", "3.3")]
  [PluginDependency("HeuristicLab.Random", "3.3")]
  public class HeuristicLabAlgorithmsSimulatedAnnealingPlugin : PluginBase {
  }
}
