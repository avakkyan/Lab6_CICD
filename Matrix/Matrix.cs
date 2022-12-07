namespace Matrix;

public class Matrix
{
    private List<List<double>> _matrix;

    public Matrix()
    {
        _matrix = new List<List<double>>();
    }

    public Matrix(List<List<double>> matrix)
    {
        _matrix = matrix ?? throw new ArgumentException("Matrix is null");
    }

    public List<List<double>> GetMatrix => _matrix;

    public void SetMatrix(List<List<double>> matrix)
    {
        _matrix = matrix ?? throw new ArgumentException("Matrix is null");
    }

    public bool CheckSymmetricMatrix()
    {
        if (_matrix is null)
            throw new ArgumentException("Matrix is null");
        if (_matrix.Count != _matrix[0].Count)
            throw new ArgumentException("Matrix is not squared");
        int n = _matrix.Count;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (_matrix[i][j] != _matrix[j][i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}