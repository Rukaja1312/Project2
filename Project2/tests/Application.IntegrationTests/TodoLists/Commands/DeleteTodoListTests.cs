using FluentAssertions;
using NUnit.Framework;
using Project2.Application.Common.Exceptions;
using Project2.Application.TodoLists.Commands.CreateTodoList;
using Project2.Application.TodoLists.Commands.DeleteTodoList;
using Project2.Domain.Entities;

using static Testing;

namespace Project2.Application.IntegrationTests.TodoLists.Commands;
public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
