<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--descargar paquete nuget AjaxControlToolkit para controles --%>
        <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
    <asp:Label ID="lblHidden" runat="server" Text=""></asp:Label>
   <%-- Para levantar ventana modal desde el servidor --%>
    <ajaxToolkit:ModalPopupExtender ID="mpeModalISR" runat="server" TargetControlID="lblHidden" PopupControlID="venModalSrvISR" DropShadow="true"></ajaxToolkit:ModalPopupExtender>
  
    <div class="form-horizontal">
        <h2>Datos del Alumno</h2>
        <asp:Label ID="lblMensajes" runat="server" Text="" CssClass="text-danger"></asp:Label>

        <dl class="dl-horizontal">
            <dt>ID</dt>
            <dd>
                <asp:Label ID="lblID" runat="server" Text="Label" ClientIDMode="Static"></asp:Label>
            </dd>
            <dt>Nombre</dt>
            <dd>
                <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Primer Apellido</dt>
            <dd>
                <asp:Label ID="lblPrimerApellido" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Segundo Apellido</dt>
            <dd>
                <asp:Label ID="lblSegundoApellido" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Fecha Nacimiento</dt>
            <dd>
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>CURP</dt>
            <dd>
                <asp:Label ID="lblCURP" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Correo</dt>
            <dd>
                <asp:Label ID="lblCorreo" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Telefono</dt>
            <dd>
                <asp:Label ID="lblTelefono" runat="server" Text="Label"></asp:Label>
            </dd>            
            <dt>Sueldo Mensual</dt>
            <dd>
                <asp:Label ID="lblSueldoMensual" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Estado</dt>
            <dd>
                <asp:Label ID="lblEstado" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Estatus</dt>
            <dd>
                <asp:Label ID="lblEstatus" runat="server" Text="Label"></asp:Label>
            </dd>
            </dl>
            <div class="form-group">
                <div class="col-md-2">
                    <%--<asp:Button ID="btnIMSS" runat="server" Text="CalcularIMSS" cssClass="btn btn-primary btn-md" OnClick="btnIMSS_Click"/>--%>
                    <input id="iModal" type="button" onclick="CalcularIMSS()" class="btn btn-primary btn-md" value="CalcularIMSS" />
                </div>

                <div class="col-md-2">
                    <asp:Button ID="btnISR" runat="server" Text="CalcularISR" OnClick="btnISR_Click" cssClass="btn btn-secundary btn-md"/>
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-2">
                    <a href="Index.aspx">Regresar a Lista</a>
                </div>
            </div>
    </div>
    <%--Ventana Modal IMSS - Cliente--%>
  <div class="modal" id="venModalclienteIMSS">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Cálculo del IMSS</h4>
                    <asp:Button ID="btnX" runat="server" Text="&times;" class="close" OnClick="btnCancelar_Click" />
                </div>
                <!-- Cuerpo de la Modal -->
                <div class="modal-body">
                    <dl>
                        <dt>Enfermedades y Maternidad</dt>
                        <dd>
                            <asp:Label ID="lblEnfermedades" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Invalidez y Vida</dt>
                        <dd>
                            <asp:Label ID="lblInvalidez" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Retiro</dt>
                        <dd>
                            <asp:Label ID="lblRetiro" runat="server" Text="Label"></asp:Label>
                        </dd>

                        <dt>Cesantia</dt>
                        <dd>
                            <asp:Label ID="lblCesantia" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Infonavit</dt>
                        <dd>
                            <asp:Label ID="lblInfonavit" runat="server" Text="Label"></asp:Label>
                        </dd>

                    </dl>

                </div>
                <!-- Modal footer -->
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>

    </div>
    <%--Ventana Modal ISR - Servidor--%>
  <div id="venModalSrvISR">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Cálculo del ISR</h4>
                    <asp:Button ID="btnXISR" runat="server" Text="&times;" class="close" OnClick="btnCerrarISR_Click" />
                </div>
                <!-- Cuerpo de la Modal -->
                <div class="modal-body">
                    <dl>
                        <dt>Limite Inferior</dt>
                        <dd>
                            <asp:Label ID="lblLimInf" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Limite Superior</dt>
                        <dd>
                            <asp:Label ID="lblLimSup" runat="server" Text="Label"></asp:Label>
                        </dd>

                        <dt>Cuota Fija</dt>
                        <dd>
                            <asp:Label ID="lblCuotaFija" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Excedente Limite Inferior</dt>
                        <dd>
                            <asp:Label ID="lblExcedente" runat="server" Text="Label"></asp:Label>
                        </dd>

                        <dt>Subsidio</dt>
                        <dd>
                            <asp:Label ID="lblSubsidio" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Impuesto</dt>
                        <dd>
                            <asp:Label ID="lblImpuesto" runat="server" Text="Label"></asp:Label>
                        </dd>

                    </dl>

                </div>
                <!-- Modal footer -->
                <div class="modal-footer">
                    <asp:Button ID="btnCerrarISR" runat="server" Text="Cerrar" CssClass="btn btn-danger" OnClick="btnCerrarISR_Click" />
                </div>
            </div>
        </div>

    </div>
    <script type="text/javascript">

        function CalcularIMSS() {
            var urlws = 'https://localhost:44366/WSAlumnos.asmx/CalcularIMSS';
            var id = $("#lblID").text();
            var alumno = { id: id};
            var parametros = JSON.stringify(alumno);
            LLamaAJAXPost(urlws, parametros, MuestraAportacionesIMSS);
           

        }
        function LLamaAJAXPost(url, parametros,funcionExito) {
            $.ajax(
            {
                type: 'POST',
                url: url,
                data: parametros,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: funcionExito,
                error: errorGenerico
                }
            );

        }

        function MuestraAportacionesIMSS(data) {
            try {
                imss = data.d;
                if (imss != null) {
                    $("#<%= lblEnfermedades.ClientID%>").text(imss.EnfermedadesMaternidad);
                    $("#<%= lblInvalidez.ClientID%>").text(imss.InvalidezVida);
                    $("#<%= lblRetiro.ClientID%>").text(imss.Retiro);
                    $("#<%= lblCesantia.ClientID%>").text(imss.Cesantia);
                    $("#<%= lblInfonavit.ClientID%>").text(imss.Infonavit);
                    $("#venModalclienteIMSS").modal();
                }
                else {
                    alert('La respuesta recibida del Web Service es incorrecta ' + data.d);
                }
            }
            catch (ex) {
                alumno = [];
                alert('Error al recibir los datos');
            }
        }



        function errorGenerico(jqXHR, exception) {
            var msg = '';
            if (jqXHR.status === 0) {
                msg = 'No está conectado, favor de verificar su conexión.';
            }
            else if (jqXHR.status === 404) {
                msg = 'Página no encontrada [404]';
            }
            else if (jqXHR.status === 500) {
                msg = 'Error no hay conexión al servidor [500]';
            }
            else if (jqXHR.status === 'parseerror') {
                msg = 'El parseo del JSON es erróneo.';
            }
            else if (jqXHR.status === 'timeout') {
                $('body').addClass('loaded');
            }
            else if (jqXHR.status === 'abort') {
                msg = 'La petición Ajax fue abortada.';
            }
            else {
                msg = 'Error no conocido. ';
                console.log(exception);
            }
            alert(msg);
        }

    </script>
</asp:Content>
