<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="EmployeeRoster">
    <html>
      <body>
        <p>
          Employee Roster(Last update on <b>
            <xsl:value-of select="LastUpdated"/>
          </b>)
        </p>
        <table border="1">
          <td>ID</td>
          <td>Name</td>
          <td>Hourly Rate</td>
          <xsl:apply-templates select="Employees/Employee"/>
        </table>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="Employees/Employee">
    <tr>
      <td>
        <xsl:value-of select="@id"/>
      </td>
      <td>
        <xsl:value-of select="Name"/>
      </td>
      <td>
        <xsl:value-of select="HourlyRate"/>
      </td>
    </tr>
  </xsl:template>
</xsl:stylesheet>

