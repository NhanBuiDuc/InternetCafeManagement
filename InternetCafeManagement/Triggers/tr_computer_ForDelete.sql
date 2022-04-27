CREATE TRIGGER tr_computer_ForDelete
ON computer
FOR Delete
AS
BEGIN

	Declare @roomID int
	Select @roomID = roomID from deleted

	UPDATE computer_room set compNum = compNum - 1 
	WHERE @roomID = computer_room.id
END