<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculatorClientApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
  <div> 
      <div>Name (good morning): <asp:TextBox id="txtName" runat="server"></asp:TextBox>
          <asp:Button id="btnGM" Text="SayGoodMorning" runat="server" OnClick="btnGM_Click"/>
           <asp:Button id="btnGMTCP" Text="SayGoodMorning (TCP)" runat="server" OnClick="btnGMTCP_Click"/>
          <span id="spnGoodMorning" runat="server"></span>
      </div>
  </div>
    <br />
    <div> 
        <div>Name (How is ur day): <asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
            <asp:Button id="btnHD" Text="Howd are you" runat="server" OnClick="btnHD_Click"/>
             <asp:Button id="btnHDTCP" Text="Howd are you (TCP)" runat="server" OnClick="btnHDTCP_Click"/>
            <span id="spnbtnHD" runat="server"></span>
         </div>
  </div>
    <br />

    <asp:Button id="btnOpening" runat="server" Text="Get Jobs" OnClick="btnOpening_Click"/>
       <asp:Button id="btnOpeningTCP" runat="server" Text="Get Jobs (TCP)" OnClick="btnOpeningTCP_Click"/>
    <br />
     <asp:GridView runat="server" ID="GridView1"></asp:GridView>
    <hr />
    Enter Role:
    <asp:TextBox ID="txtRole" runat="server"></asp:TextBox><br />
    <asp:Button  runat="server" id="btnRoleSearch" OnClick="btnRoleSearch_Click" Text="RoleSearch" />
     <asp:Button  runat="server" id="btnRoleSearchTCP" OnClick="btnRoleSearchTCP_Click" Text="RoleSearch (TCP)" />
    <asp:GridView runat="server" ID="gvJobs"></asp:GridView>
    <hr />
    <table>
        <tr>
            <td>
                Enter First number:
            </td>
            <td>
               <asp:TextBox id="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                Enter second number:
            </td>
            <td>
               <asp:TextBox id="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button id="btnAdd" Text="Add" runat="server" OnClick="btnAdd_Click"/>
            </td>
             <td>
                <asp:Button id="btnSub" Text="Sub" runat="server" OnClick="btnSub_Click"/>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Button id="btnMul" Text="Mul" runat="server" OnClick="btnMul_Click"/>
            </td>
             <td>
                <asp:Button id="btnDiv" Text="Div" runat="server" OnClick="btnDiv_Click"/>
            </td>
        </tr>
        <tr>
            <td>
               Result
            </td>
             <td>
                <asp:Label runat="server" ID="lblCalResult"></asp:Label>
            </td>
        </tr>
    </table>   

</asp:Content>
