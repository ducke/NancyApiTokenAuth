function New-ApiUser {
  [CmdletBinding()]
  param(
    $Username,
    $Password
  )
  try {
    $person = @{
        username=$Username
        password=$Password
      }
      $Headers = @{
              'Accept' = '*/*'
              'content-type' = 'application/json'
      }

      $json = $person | ConvertTo-Json -Compress

      $Respond = Invoke-WebRequest -Method POST -Uri 'http://localhost.fiddler:8080/api/register' -Header $Headers -Proxy 'http://localhost:8888' -Body $json -ErrorAction Stop
      if ($Respond.Statuscode -ne 200) {
        Write-Error 'Schief gelaufen'
  
      }  
  }
  catch {
    $PSCmdlet.ThrowTerminatingError($_)
  }
}

function Get-ApiToken {
  [CmdletBinding()]
  param(
    $Username,
    $Password
  )
  $Header = @{
    'content-type' = 'application/x-www-form-urlencoded'
  }
  $token = @{
    grant_type='password'
    username=$Username
    password=$Password
  }
  $response = Invoke-WebRequest -Method Post -Uri 'http://localhost.fiddler:8080/token' -Headers $header -Proxy 'http://localhost:8888' -Body $token
  ($response.Content | ConvertFrom-Json).access_token
}

function Get-AuthRequest {
  [CmdletBinding()]
  param(
    $Token
  )
  $HeaderValue = 'Bearer ' + $Token
  Invoke-RestMethod -Uri http://localhost.fiddler:8080/api/admin -Headers @{Authorization = $HeaderValue} -Proxy 'http://localhost:8888'
}