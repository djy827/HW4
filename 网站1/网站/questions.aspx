<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="questions.aspx.cs" Inherits="网站.questions" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>答题界面</title>
    <script type="text/javascript">
        var int = setInterval("time()", 1000);
        var num = 3600;
        function time() {
            num > 0 ? num-- : clearInterval(int);
            var minutes = parseInt((num % 3600) / 60);
            var seconds = num % 60;

            document.getElementById("clock").innerHTML = "还剩" + minutes + "分钟" + seconds
                + "秒";
        }
    </script>
   
</head>
                <body>
                    <span id="clock"></span>
                    <form id="form1" runat="server">
                    <br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="79px" ReadOnly="True" Width="702px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" OnCheckedChanged="RadioButton2_CheckedChanged" />
                        <p>
                            你的选择：
                 
                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" OnCheckedChanged="RadioButton1_CheckedChanged1" />
                            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" OnCheckedChanged="RadioButton3_CheckedChanged" />
                            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" OnCheckedChanged="RadioButton4_CheckedChanged" />
                </p>
                        <label>A</label> <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;<label>B</label> <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;<label>C</label> <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label> <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                        <br />
                    <br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="79px" ReadOnly="True" Width="702px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <p>
                            你的选择：
                </p>
                        <label>A</label>
                        <input type="radio" value="1" name="2" /><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
&nbsp;<label>B</label>
                        <input type="radio" value="2" name="2" /><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
&nbsp;<label>C</label>
                        <input type="radio" value="3" name="2" /><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label>
                        <input type="radio" value="4" name="2"  /><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                        <br />
&nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="79px" ReadOnly="True" Width="702px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <p>
                            你的选择：
                </p>
                        <label>A</label>
                        <input type="radio" value="1" name="3" /><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
&nbsp;<label>B</label>
                        <input type="radio" value="2" name="3" />
                        <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                        <label>C</label>
                        <input type="radio" value="3" name="3" /><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label>
                        <input type="radio" value="4" name="3"  /><asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                        <br />
&nbsp;<asp:TextBox ID="TextBox4" runat="server" Height="79px" ReadOnly="True" Width="702px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <p>
                            你的选择：
                </p>
                        <label>A</label>
                        <input type="radio" value="1" name="4" /><asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
&nbsp;<label>B</label>
                        <input type="radio" value="2" name="4" /><asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
&nbsp;<label>C</label>
                        <input type="radio" value="3" name="4" /><asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label>
                        <input type="radio" value="4" name="4"  /><asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                        <br />
&nbsp;<asp:TextBox ID="TextBox5" runat="server" Height="79px" ReadOnly="True" Width="702px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <p>
                            你的选择：
                </p>
                        <label>A</label>
                        <input type="radio" value="1" name="5"/><asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
&nbsp;<label>B</label>
                        <input type="radio" value="2" name="5" /><asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
&nbsp;<label>C</label>
                        <input type="radio" value="3" name="5" /><asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label>
                        <input type="radio" value="4" name="5" /><asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
                        <br />
&nbsp;<asp:TextBox ID="TextBox6" runat="server" Height="79px" ReadOnly="True" Width="702px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <p>
                            你的选择：
                </p>
                        <label>A</label>
                        <input type="radio" value="1" name="6" /><asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
&nbsp;<label>B</label>
                        <input type="radio" value="2" name="6"/><asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
&nbsp;<label>C</label>
                        <input type="radio" value="3" name="6"/><asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label>
                        <input type="radio" value="4" name="6" /><asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
                        <br />
&nbsp;<asp:TextBox ID="TextBox7" runat="server" Height="79px" ReadOnly="True" Width="702px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <p>
                            你的选择：
                </p>
                        <label>A</label>
                        <input type="radio" value="1" name="7"/><asp:Label ID="Label25" runat="server" Text="Label"></asp:Label>
&nbsp;<label>B</label>
                        <input type="radio" value="2" name="7" /><asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
&nbsp;<label>C</label>
                        <input type="radio" value="3" name="7" /><asp:Label ID="Label27" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label>
                        <input type="radio" value="4" name="7"  /><asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
                        <br />
&nbsp;<asp:TextBox ID="TextBox8" runat="server" Height="79px" ReadOnly="True" Width="702px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <p>
                            你的选择：
                </p>
                        <label>A</label>
                        <input type="radio" value="1" name="8" /><asp:Label ID="Label29" runat="server" Text="Label"></asp:Label>
&nbsp;<label>B</label>
                        <input type="radio" value="2" name="8" /><asp:Label ID="Label30" runat="server" Text="Label"></asp:Label>
&nbsp;<label>C</label>
                        <input type="radio" value="3" name="8" /><asp:Label ID="Label31" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label>
                        <input type="radio" value="4" name="8"  /><asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
                        <br />
&nbsp;<asp:TextBox ID="TextBox9" runat="server" Height="79px" ReadOnly="True" Width="702px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <p>
                            你的选择：
                </p>
                        <label>A</label>
                        <input type="radio" value="1" name="9" /><asp:Label ID="Label33" runat="server" Text="Label"></asp:Label>
&nbsp;<label>B</label>
                        <input type="radio" value="2" name="9" /><asp:Label ID="Label34" runat="server" Text="Label"></asp:Label>
&nbsp;<label>C</label>
                        <input type="radio" value="3" name="9" /><asp:Label ID="Label35" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label>
                        <input type="radio" value="4" name="9"  /><asp:Label ID="Label36" runat="server" Text="Label"></asp:Label>
                        <br />
&nbsp;<asp:TextBox ID="TextBox10" runat="server" Height="79px" ReadOnly="True" Width="702px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <p>
                            你的选择：
                </p>
                        <label>A</label>
                        <input type="radio" value="1" name="10" /><asp:Label ID="Label37" runat="server" Text="Label"></asp:Label>
&nbsp;<label>B</label>
                        <input type="radio" value="2" name="10" /><asp:Label ID="Label38" runat="server" Text="Label"></asp:Label>
&nbsp;<label>C</label>
                        <input type="radio" value="3" name="10" /><asp:Label ID="Label39" runat="server" Text="Label"></asp:Label>
&nbsp;<label>D</label>
                        <input type="radio" value="4" name="10"  /><asp:Label ID="Label40" runat="
                        <input type="radio" value="4" name="10"  /><asp:Label ID="Label40" runat="server" Text="Label"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label41" runat="server" Text="Label"></asp:Label>
                        <br />
                      
                    </form>
                </body>
</html >

