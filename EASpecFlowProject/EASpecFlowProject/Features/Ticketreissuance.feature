Feature: Ticket reissuance	
	Como usuario pasajero 
	quiero reemitir mi ticket
	para asegurar que mis datos están actualizados

@mytag
Scenario: Usuario actualiza sus datos personales
	Given el usuario brinda nuevos datos personales
	When el usuario pida reemitir su ticket
	Then el sistema muetsra el ticket con los datos actualizados
	Examples: 
		| Número de ticket | Nombre Pasajero | Destino | Fecha de Salida | Hora de Salida |
		| 1500             | Juan Carlos     | Cusco   | 2023-10-01      | 09:00          |

		| Número de ticket | Nombre Pasajero | Destino | Fecha de Salida | Hora de Salida |
		| 1500             | Juan Escalante  | Cusco   | 2023-10-01      | 09:00          |

Scenario: Usuario quiere cambiar destino del vuelo
	Given el usuario coloca nuevo destino de vuelo
	When el usuario confirme el nuevo destino de vuelo
	Then el sistema actualiza el ticket con el nuevo destino brindado
	
	Examples:
		| Número de ticket | Nombre Pasajero | Destino | Fecha de Salida | Hora de Salida |
		| 1500             | Juan Carlos     | Cusco   | 2023-10-01      | 09:00          |

		| Número de ticket | Nombre Pasajero | Destino | Fecha de Salida | Hora de Salida |
		| 1500             | Juan Escalante  | Arequipa| 2023-10-01      | 09:00          |

Scenario: Usuario quiere cambiar la fecha de vuelo
	Given el usuario agenda la nueva fecha de vuelo
	When el usuario confirma la nueva fecha de vuelo
	Then el sistema actualiza el ticket con la nueva fecha brindada
	
	Examples:
		| Número de ticket | Nombre Pasajero | Destino | Fecha de Salida | Hora de Salida |
		| 1500             | Juan Carlos     | Cusco   | 2023-10-01      | 09:00          |
	
		| Número de ticket | Nombre Pasajero | Destino | Fecha de Salida | Hora de Salida |
		| 1500             | Juan Escalante  | Arequipa| 2023-10-10      | 09:00          |