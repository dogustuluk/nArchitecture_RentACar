using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class BaseController : ControllerBase
{
	//protected --> bunu sadece inherit edenler kullanabilsin diye yazıldı.
			//--> protected olanlar büyük harfle yazılır.
			//_mediator?? ile set edilmiş mi diye anlarız.
	private IMediator? _mediator;
	protected IMediator? Mediator => _mediator??= HttpContext.RequestServices.GetService<IMediator>(); //eğer daha önceden _mediator enjekte edildiyse onu döndür yoksa httpcontext'li kısmı ioc ortamından IMediator'un karşılığını bana ver demiş olur bu kod.
}
