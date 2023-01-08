Module Functions

    Friend Function cleanString(ByVal s As String) As String

        Dim tmp As String = s.Replace("[", "")
        tmp = tmp.Replace("]", "")
        tmp = tmp.Replace("""", "")
        Return tmp

    End Function

End Module
