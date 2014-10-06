Microsoft Visual Studio Solution File, Format Version 11.00
# Visual Studio 2010
{foreach name=projects item=project from=$projects}
{if $project->projectFileExt eq ".csproj"}
Project("{literal}{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}{/literal}") = "{$project->name}", "projects/{$project->name}{$project_ext}", "{$project->guid}"
{else}
Project("{$solution_guid}") = "{$project->name}", "projects/{$project->name}{$project_ext}", "{$project->guid}"
{/if}
EndProject
{/foreach}
{foreach key=pname item=v from=$projectExtRefs}
Project("{$v[2]}") = "{$pname}", "{$v[0]}", "{$v[1]}"
EndProject
{/foreach}
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Win32 = Debug|Win32
		Debug|x64 = Debug|x64
		Release|Win32 = Release|Win32
		Release|x64 = Release|x64
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
{foreach name=projects item=project from=$projects}
		{$project->guid}.Debug|Win32.ActiveCfg = Debug|Win32
		{$project->guid}.Debug|Win32.Build.0 = Debug|Win32
		{$project->guid}.Debug|x64.ActiveCfg = Debug|x64
		{$project->guid}.Debug|x64.Build.0 = Debug|x64
		{$project->guid}.Release|Win32.ActiveCfg = Release|Win32
		{$project->guid}.Release|Win32.Build.0 = Release|Win32
		{$project->guid}.Release|x64.ActiveCfg = Release|x64
		{$project->guid}.Release|x64.Build.0 = Release|x64
{/foreach}
{foreach key=pname item=v from=$projectExtRefs}
		{$v[1]}.Debug|Win32.ActiveCfg = Debug|Win32
		{$v[1]}.Debug|Win32.Build.0 = Debug|Win32
		{$v[1]}.Debug|x64.ActiveCfg = Debug|x64
		{$v[1]}.Debug|x64.Build.0 = Debug|x64
		{$v[1]}.Release|Win32.ActiveCfg = Release|Win32
		{$v[1]}.Release|Win32.Build.0 = Release|Win32
		{$v[1]}.Release|x64.ActiveCfg = Release|x64
		{$v[1]}.Release|x64.Build.0 = Release|x64
{/foreach}
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal
