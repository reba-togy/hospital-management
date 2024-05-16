Imports System

Class Patient
    Public Name As String
    Public Age As Integer
    Public Gender As String

    ' Constructor
    Public Sub hospital(name As String, age As Integer, gender As String)
        My.Name = name
        My.Age = age
        My.Gender = gender
    End Sub

    ' Destructor
    Protected Overrides Sub Finalize()
        Console.WriteLine($"Patient {Name} has been removed.")
        MyBase.Finalize()
    End Sub
End Class

Module HospitalManagement
    Dim Patients As New List(Of Patient)

    Sub Main()
        Dim choice As Integer
        Do
            Console.WriteLine("Hospital Management System")
            Console.WriteLine("1. Add Patient")
            Console.WriteLine("2. View Patients")
            Console.WriteLine("3. Exit")
            Console.Write("Enter your choice: ")
            choice = Convert.ToInt32(Console.ReadLine())

            Select Case choice
                Case 1
                    AddPatient()
                Case 2
                    ViewPatients()
                Case 3
                    Console.WriteLine("Exiting program...")
                Case Else
                    Console.WriteLine("Invalid choice. Please select again.")
            End Select

        Loop While choice <> 3
    End Sub

    Sub AddPatient()
        Console.Write("Enter patient's name: ")
        Dim name As String = Console.ReadLine()
        Console.Write("Enter patient's age: ")
        Dim age As Integer = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter patient's gender: ")
        Dim gender As String = Console.ReadLine()

        Dim newPatient As New Patient(name, age, gender)
        Patients.Add(newPatient)
        Console.WriteLine($"Patient {name} added successfully!")
    End Sub

    Sub ViewPatients()
        If Patients.Count = 0 Then
            Console.WriteLine("No patients in the system.")
        Else
            Console.WriteLine("Patient List:")
            For Each patient As Patient In Patients
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Gender: {patient.Gender}")
            Next
        End If
    End Sub
End Module
