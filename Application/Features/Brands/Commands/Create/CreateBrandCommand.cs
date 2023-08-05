using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;

//her command'in bir tane handler'ı vardır. Bunlar birleşik olduğu için iç içe yazabiliriz. cqrs'te command ve handler olması gerekmektedir.
public class CreateBrandCommand:IRequest<CreatedBrandResponse>
{
	public string Name { get; set; }
}

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
{
	public Task<CreatedBrandResponse>? Handle(CreateBrandCommand request, CancellationToken cancellationToken)
	{
		CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
		createdBrandResponse.Name = request.Name;
		createdBrandResponse.Id = new Guid();
		return null;
	}
}

