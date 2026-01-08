using NUnit.Framework;
using Ticketreissuance;
using EASpecFlowProject;

namespace EASpecFlowProject.StepDefinitions
{
    [Binding]
    public class TicketReissuanceSteps
    {
        private readonly Ticketreissuance _ticketRepository;

        public TicketReissuanceSteps(Ticketreissuance ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        [Given("el usuario brinda nuevos datos personales")]
        public void ElUsuarioBrindaNuevosDatosPersonales(int ticketId, string nombrePasajero, string destino, string fechaSalida, string horaSalida)
        {
            var ticket = _ticketRepository.GetTicket(ticketId);
            ticket.NombrePasajero = nombrePasajero;
            ticket.Destino = destino;
            ticket.FechaSalida = fechaSalida;
            ticket.HoraSalida = horaSalida;
            _ticketRepository.SaveTicket(ticket);
        }

        [When("el usuario pida reemitir su ticket")]
        public void ElUsuarioPidaReemitirSuTicket(int ticketId)
        {
            var ticket = _ticketRepository.GetTicket(ticketId);
            ticket.Reemitido = true;
            _ticketRepository.SaveTicket(ticket);
        }

        [Then("el sistema muetsra el ticket con los datos actualizados")]
        public void ElSistemaMuetsraElTicketConLosDatosActualizados(int ticketId, string nombrePasajero, string destino, string fechaSalida, string horaSalida)
        {
            var ticket = _ticketRepository.GetTicket(ticketId);
            Assert.AreEqual(nombrePasajero, ticket.NombrePasajero);
            Assert.AreEqual(destino, ticket.Destino);
            Assert.AreEqual(fechaSalida, ticket.FechaSalida);
            Assert.AreEqual(horaSalida, ticket.HoraSalida);
        }

        [Given("el usuario coloca nuevo destino de vuelo")]
        public void ElUsuarioColocaNuevoDestinoDeVuelo(int ticketId, string nuevoDestino)
        {
            var ticket = _ticketRepository.GetTicket(ticketId);
            ticket.Destino = nuevoDestino;
            _ticketRepository.SaveTicket(ticket);
        }

        [When("el usuario confirme el nuevo destino de vuelo")]
        public void ElUsuarioConfirmeElNuevoDestinoDeVuelo(int ticketId)
        {
            var ticket = _ticketRepository.GetTicket(ticketId);
            ticket.Reemitido = true;
            _ticketRepository.SaveTicket(ticket);
        }

        [Then("el sistema actualiza el ticket con el nuevo destino brindado")]
        public void ElSistemaActualizaElTicketConElNuevoDestinoBrindado(int ticketId, string nuevoDestino)
        {
            var ticket = _ticketRepository.GetTicket(ticketId);
            Assert.AreEqual(nuevoDestino, ticket.Destino);
        }

        [Given("el usuario agenda la nueva fecha de vuelo")]
        public void ElUsuarioAgendaLaNuevaFechaDeVuelo(int ticketId, string nuevaFecha)
        {
            var ticket = _ticketRepository.GetTicket(ticketId);
            ticket.FechaSalida = nuevaFecha;
            _ticketRepository.SaveTicket(ticket);
        }

        [When("el usuario confirme la nueva fecha de vuelo")]
        public void ElUsuarioConfirmeLaNuevaFechaDeVuelo(int ticketId)
        {
            var ticket = _ticketRepository.GetTicket(ticketId);
            ticket.Reemitido = true;
            _ticketRepository.SaveTicket(ticket);
        }

        [Then("el sistema actualiza el ticket con la nueva fecha brindada")]
        public void ElSistemaActualizaElTicketConLaNuevaFechaBrindada(int ticketId, string nuevaFecha)
        {
            var ticket = _ticketRepository.GetTicket(ticketId);
            Assert.AreEqual(nuevaFecha, ticket.FechaSalida);
        }
    }
}