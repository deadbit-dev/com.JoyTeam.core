using System.Collections.Generic;

namespace JoyTeam.Core
{
    public interface IGraph
    {
        public void AddEdge(int from, int to);
        public void SetWeight(int node, float weight);
        public float GetWeight(int node);
        public List<int> GetNeightbours(int node);
    }
}