using System.Collections.Generic;

namespace JoyTeam.Core
{
    /// <summary>
    /// Class <c>ALGraph</c> implementation <c>IGraph</c> throught adjacency list.
    /// </summary>
    public class ALGraph : IGraph
    {
        private int _nodes;
        private float[] _weight;
        private List<int>[] _edges;

        public ALGraph(int nodes, float defaultWeight = 1.0f)
        {
            for(var i = 0; i < this._nodes; i++)
            {
                this._weight[i] = defaultWeight;
                this._edges[i] = new List<int>();
            }
        }

        public void AddEdge(int from, int to)
        {
            this._edges[from].Add(to);
        }

        public List<int> GetNeightbours(int node)
        {
            return this._edges[node];
        }

        public float GetWeight(int node)
        {
            return this._weight[node];
        }

        public void SetWeight(int node, float weight)
        {
            this._weight[node] = weight;
        }
    }
}