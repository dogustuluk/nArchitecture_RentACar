using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application;

public static class ApplicationServiceRegistration
{
	//extensionlar static olmalı
	public static IServiceCollection AddApllicationServices(this IServiceCollection services)
	{
		services.AddMediatR(configuration =>
		{
			configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());//mevcut assembly'de ara
		});

		return services;
	}
}
