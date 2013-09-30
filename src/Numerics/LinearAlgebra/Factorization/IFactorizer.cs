using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathNet.Numerics.LinearAlgebra.Factorization
{
    /// <summary>
    /// Classes that factor a matrix into two components where the resulting matrixes W and H
    ///  when multiplied together closely approximate the original matrix V, <c>V ≈ WH</c>.
    /// The dimensions of the matrix factors W and H are n x r and r x m, respectively. 
    /// The rank r of the factorization is generally chosen so that (n + m)r &lt; nm, and the product WH can be regarded as a compressed form of the data in V.
    /// </summary>
    /// <typeparam name="T">Supported data types are double, single, <see cref="Complex"/>, and <see cref="Complex32"/>.</typeparam>
    public interface IFactorizer<T> where T : struct, IEquatable<T>, IFormattable
    {
        void Factor(Matrix<T> vInput, int rank, Matrix<T> wResult, Matrix<T> hResult);
    }
}
