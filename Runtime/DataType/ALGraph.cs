using System.Collections.Generic;

namespace JoyTeam.Core.DataType
{
    /// <summary>
    /// Class <c>ALGraph</c> implementation <c>IGraph</c> throught adjacency list.
    /// </summary>
    public class ALGraph : IGraph
    {
        private int _nodes;
        private List<float> _weight;
        private List<List<int>> _edges;

        public ALGraph(int nodes, float defaultWeight = 1.0f)
        {
            for(var i = 0; i < this._nodes; i++)
            {
                this._weight[i] = defaultWeight;
                this._edges[i] = new List<int>();
            }
        }

        public void AddNode(int node)
        {
            this._edges[node] = new List<int>();
            this._nodes++;
        }

        public void RemoveNode(int node)
        {
            throw new System.NotImplementedException();
        }

        public void AddEdge(int from, int to)
        {
            this._edges[from].Add(to);
        }

        public void RemoveEdge(int from, int to)
        {
            throw new System.NotImplementedException();
        }

        public void SetWeight(int node, float weight)
        {
            this._weight[node] = weight;
        }

        public float GetWeight(int node)
        {
            return this._weight[node];
        }
        
        public List<int> GetNeightbours(int node)
        {
            return this._edges[node];
        }
    }
}