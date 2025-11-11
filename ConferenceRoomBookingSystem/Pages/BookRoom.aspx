<%@ Page Title="Rezerwacja sali" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="BookRoom.aspx.cs" 
    Inherits="ConferenceRoomBookingSystem.Pages.BookRoom" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="<%= ResolveUrl("~/Styles/BookRoom.css") %>" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="bookroom-container">
        <div class="bookroom-header">
            <h2 class="bookroom-title">Rezerwacja sali konferencyjnej</h2>
        </div>
    
        <div class="bookroom-content">
            <!-- Szczegóły sali -->
            <div>
                <asp:FormView ID="fvRoomDetails" runat="server">
                    <ItemTemplate>
                        <div class="room-details-card">
                            <h3 class="room-details-title"><%# Eval("RoomName") %></h3>
                            <div class="room-details-info">
                                <div class="room-details-item">
                                    <span class="room-details-label">Pojemność:</span>
                                    <span class="room-details-value"><%# Eval("Capacity") %> osób</span>
                                </div>
                                <div class="room-details-item">
                                    <span class="room-details-label">Lokalizacja:</span>
                                    <span class="room-details-value"><%# Eval("Location") %></span>
                                </div>
                                <div class="room-details-item">
                                    <span class="room-details-label">Opis:</span>
                                    <span class="room-details-value"><%# Eval("Description") %></span>
                                </div>
                            </div>
                            <div class="room-equipment">
                                <span class="room-equipment-label">Wyposażenie:</span>
                                <div class="equipment-badges">
                                    <%# GetEquipmentText(Eval("HasProjector"), Eval("HasWhiteboard"), Eval("HasAudioSystem"), Eval("HasWiFi")) %>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:FormView>
            </div>

        </div>
       
        <asp:Label ID="lblMessage" runat="server" CssClass="alert" Visible="false"></asp:Label>
    </div>
</asp:Content>