using System.Collections.Generic;

namespace JoyTeam.Core.DataType
{
    public interface IGraph
    {
        public void AddNode(int node);
        public void RemoveNode(int node);
        public void AddEdge(int from, int to);
        public void RemoveEdge(int from, int to);
        public void SetWeight(int node, float weight);
        public float GetWeight(int node);
        public List<int> GetNeightbours(int node);
    }
}