param (
	[Parameter(Mandatory=$true)][string]$solutionPath
)

Function GetJsonConfig{

	$jsonConfig = Join-Path -Path $solutionPath -ChildPath "Scripts" | Join-Path -ChildPath "PostPublishConfig.json"
	
	if ((Test-Path $jsonConfig) -eq $true){$jsonObject = Get-Content $jsonConfig | ConvertFrom-Json}
	else{throw [System.ArgumentException] "$jsonConfig does not exist."}
	
	return $jsonObject
}

Function Find-MsBuild([string] $path)
{
	$rootPath = "C:\Program Files\Microsoft Visual Studio\2022"
	$buildPart = "Community\MSBuild\Current\Bin\msbuild.exe"
	$agentPath = "$rootPath$vsPart\BuildTools\$buildPart"
	If (Test-Path $agentPath) { return $agentPath } 
	$agentPath = "$rootPath$vsPart\Enterprise\$buildPart"
	If (Test-Path $agentPath) { return $agentPath } 
	$agentPath = "$rootPath$vsPart\Professional\$buildPart"
	If (Test-Path $agentPath) { return $agentPath } 
	$agentPath = "$rootPath$vsPart\Community\$buildPart"
	If (Test-Path $agentPath) { return $agentPath } 

	$rootPath = "C:\Program Files\Microsoft Visual Studio\2022"
	$agentPath = "$rootPath$vsPart\BuildTools\$buildPart"
	If (Test-Path $agentPath) { return $agentPath } 
	$agentPath = "$rootPath$vsPart\Enterprise\$buildPart"
	If (Test-Path $agentPath) { return $agentPath } 
	$agentPath = "$rootPath$vsPart\Professional\$buildPart"
	If (Test-Path $agentPath) { return $agentPath } 
	$agentPath = "$rootPath$vsPart\Community\$buildPart"
	If (Test-Path $agentPath) { return $agentPath } 

    return $path
}

# Config values from JSON file
$jsonObject = GetJsonConfig
[String]$msBuildExe = Find-MsBuild($jsonObject.config.msBuildExe)
[String]$siteName = $jsonObject.config.siteName
[bool]$prune = $jsonObject.config.prune

#Get the paths to the site, based on site inputname
$appCmd = "$Env:SystemRoot\system32\inetsrv\appcmd.exe" 
[xml]$site = & $appCmd list vdir "$siteName/" /config
[String]$publishTarget = $site.virtualDirectory.physicalPath

if($prune) {
	[String]$appConfigInclude = Join-Path -Path $publishTarget -ChildPath "App_Config" | Join-Path -ChildPath "Include"
	$files = Get-ChildItem $appConfigInclude
	foreach ($file in $files) {
		Remove-Item $file.FullName -Recurse
	}
}

# Publish all Foundation projects
$foundationPath = Join-Path -Path $solutionPath -ChildPath "Foundation"
if ((Test-Path $foundationPath) -eq $True) {
	$foundationProjects = Get-ChildItem $foundationPath -Recurse -Include *.csproj
	foreach ($projectFile in $foundationProjects) {
		Write-Host "Runing build foundation for" $projectFile
		& "$($msBuildExe)" "$($projectFile)" /m /nr:false /p:DeployOnBuild=true /p:DeployDefaultTarget=WebPublish /p:WebPublishMethod=FileSystem /p:Configuration=debug /p:PublishUrl=$publishTarget -v:q -nologo -clp:NoSummary > null
		if ($LastExitCode -ne 0) {
			Write-Host "Build failed for" $projectFile -foregroundcolor Magenta
			exit
		}
	}
}

# Publish all Feature projects
$featurePath = Join-Path -Path $solutionPath -ChildPath "Feature"
if ((Test-Path $featurePath) -eq $True) {
	$featureProjects = Get-ChildItem $featurePath -Recurse -Include *.csproj
	foreach ($projectFile in $featureProjects) {
		Write-Host "Runing Feature for" $projectFile
		& "$($msBuildExe)" "$($projectFile)" /m /nr:false /p:DeployOnBuild=true /p:DeployDefaultTarget=WebPublish /p:WebPublishMethod=FileSystem /p:Configuration=debug /p:PublishUrl=$publishTarget -v:q -nologo -clp:NoSummary > null
		if ($LastExitCode -ne 0) {
			Write-Host "Build failed for" $projectFile -foregroundcolor Magenta
			exit
		}
	}
}

$featurePath = Join-Path -Path $solutionPath -ChildPath "Project"
if ((Test-Path $featurePath) -eq $True) {
	$featureProjects = Get-ChildItem $featurePath -Recurse -Include *.csproj
	foreach ($projectFile in $featureProjects) {
		Write-Host "Runing Project for" $projectFile
		& "$($msBuildExe)" "$($projectFile)" /m /nr:false /p:DeployOnBuild=true /p:DeployDefaultTarget=WebPublish /p:WebPublishMethod=FileSystem /p:Configuration=debug /p:PublishUrl=$publishTarget -v:q -nologo -clp:NoSummary > null
		if ($LastExitCode -ne 0) {
			Write-Host "Build failed for" $projectFile -foregroundcolor Magenta
			exit
		}
	}
}