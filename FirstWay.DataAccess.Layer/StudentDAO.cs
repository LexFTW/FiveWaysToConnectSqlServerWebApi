using System.Collections.Generic;
using FirstWay.Common.Layer;
using FirstWay.DataAccess.Layer.Interfaces;
using FirstWay.DataAccess.Layer.Utilities;

namespace FirstWay.DataAccess.Layer
{
    public class StudentDao : IRepository<Student>
    {
        private readonly ConnectionUtility connection;

        public StudentDao()
        {
            connection = new ConnectionUtility();
        }

        public Student Create(Student model)
        {
            connection.OpenConnection();

            var command = new CommandUtility<Student>("INSERT INTO Students VALUES (@Name, @Surname, @Age, @StudentGuid);", connection);
            command.AddParameter("@Name", model.Name);
            command.AddParameter("@Surname", model.Surname);
            command.AddParameter("@Age", model.Age);
            command.AddParameter("@StudentGuid", model.StudentGuid);
            command.ExecuteNonQuery();

            connection.CloseConnection();
            return model;
        }

        public bool Delete(Student model)
        {
            return true;
        }

        public IEnumerable<Student> GetAll()
        {
            connection.OpenConnection();

            var command = new CommandUtility<Student>("SELECT * FROM Students", connection);
            var reader = new ReaderUtility<Student>(command);
            var result = new List<Student>();

            while (reader.Reader.Read())
            {
                Student student = new Student();
                student.StudentId = (int)reader.Reader["StudentId"];
                student.Name = (string)reader.Reader["Name"];
                student.Surname = (string)reader.Reader["Surname"];
                student.Age = (int)reader.Reader["Age"];
                result.Add(student);
            }

            connection.CloseConnection();

            return result;
        }

        public Student GetById(int id)
        {
            connection.OpenConnection();

            var command = new CommandUtility<Student>("SELECT * FROM Students WHERE StudentId = @id", connection);
            command.AddParameter("@id", id);

            var reader = new ReaderUtility<Student>(command);
            var student = new Student();


            while (reader.Reader.Read())
            {
                student.StudentId = (int)reader.Reader["StudentId"];
                student.Name = (string)reader.Reader["Name"];
                student.Surname = (string)reader.Reader["Surname"];
                student.Age = (int)reader.Reader["Age"];
            }

            connection.CloseConnection();
            return student;
        }

        public Student Update(int id, Student model)
        {
            connection.OpenConnection();

            var command = new CommandUtility<Student>("UPDATE Students SET (@Name, @Surname, @Age, @StudentGuid) WHERE StudentId = @id;", connection);
            command.AddParameter("@Name", model.Name);
            command.AddParameter("@Surname", model.Surname);
            command.AddParameter("@Age", model.Age);
            command.AddParameter("@StudentGuid", model.StudentGuid);
            command.AddParameter("@Id", model.StudentId);
            command.ExecuteNonQuery();

            connection.CloseConnection();
            return model;
        }
    }
}
