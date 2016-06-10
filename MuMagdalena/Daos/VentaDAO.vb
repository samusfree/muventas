Imports System.Data

Public Interface VentaDAO
    Event mensaje(ByVal mensaje As String)

    ''' <summary>
    ''' Metodo para listar las ventas segun los filtros enviados
    ''' </summary>
    ''' <param name="idJugador">Id del jugador case sensitive</param>
    ''' <param name="mtcn">MTCN o OP</param>
    ''' <param name="serie">Serie del Item</param>
    ''' <param name="fecha1">Fecha de inicio de la busqueda</param>
    ''' <param name="fecha2">Fecha de Fin de la busqueda</param>
    ''' <param name="tipoBusqueda">Tipo de busqueda 1 Normales 2 normales y cambios 3 todos los estados</param>
    ''' <returns>Lista de Items vendidos</returns>
    Function listarVentasPorFiltros(ByVal idJugador As String, ByVal mtcn As String,
                                    ByVal serie As String, ByVal fecha1 As String,
                                    ByVal fecha2 As String, ByVal tipoBusqueda As Integer) As DataTable
End Interface
