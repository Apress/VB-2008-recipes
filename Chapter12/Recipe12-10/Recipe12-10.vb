Imports System
Imports System.Security.Permissions
Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_10

        Public Shared Sub Method1()

            '  An imperative role-based security demand for the current
            '  principal to represent an identity with the name Jeremy.  The
            '  roles of the prinicpal are irrelevant.
            Dim perm As New PrincipalPermission("MACHINE\Jeremy", Nothing)

            '  Make the demand.
            perm.Demand()

        End Sub
        Public Shared Sub Method2()

            '  An imperative role-based security demand for the current
            '  principal to be a member of the roles Managers or Developers.
            '  If the prinicpal is a member of either role, access is granted.
            '  Using the PrincipalPermission, you can express only an OR type
            '  relationship.  This is because the PrincipalPolicy.Intersect method
            '  always returns an empty permission unless the two inputs are the
            '  same.  However, you can use code logic to implement more complex
            '  conditions.  In this case, the name of the identity is irrelevant.
            Dim perm1 As New PrincipalPermission(Nothing, "MACHINE\Managers")
            Dim perm2 As New PrincipalPermission(Nothing, "MACHINE\Devleopers")

            '  Make the demand.
            perm1.Union(perm2).Demand()

        End Sub
        Public Shared Sub Method3()

            '  An imperative role-based security demand for the current prinicipal
            '  to represent an identity with the name Jeremy AND be a member of the
            '  Managers role.
            Dim perm As New PrincipalPermission("MACHINE\Jeremy", "MACHINE\Managers")

            '  Make the demand.
            perm.Demand()

        End Sub
        '  A declarative role-based security demand for the current principal
        '  to represent an identity with the name Jeremy.
        <PrincipalPermission(SecurityAction.Demand, Name:="MACHINE\Jeremy")> _
        Public Shared Sub Method4()

            '  Method implementation...

        End Sub
        '  A declarative role-based security demand for the current principal
        '  to be a member of the roles Managers OR Developers.  If the principal
        '  is a member of either role, access is granted.  You can express only
        '  an OR type relationship, not an AND relationship.
        <PrincipalPermission(SecurityAction.Demand, Role:="MACHINE\Managers"), PrincipalPermission(SecurityAction.Demand, Role:="MACHINES\Developers")> _
        Public Shared Sub Method5()

            '  Method implementation...

        End Sub
        '  A declarative role-based security demand for the current principal
        '  to represent an identity with the name Jeremy and be a member of the
        '  Managers role.
        <PrincipalPermission(SecurityAction.Demand, Name:="MACHINE\Jeremy", Role:="MACHINE\Managers")> _
        Public Shared Sub Method6()

            '  Method implementation...

        End Sub

    End Class
End Namespace